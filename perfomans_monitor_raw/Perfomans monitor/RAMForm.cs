using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using OpenHardwareMonitor.Hardware;

namespace Perfomans_monitor
{
    public partial class RAMForm : Form
    {
        public RAMForm()
        {
            InitializeComponent();
            RAMNameLabel.Text = GetRAMName();
            TotalMemoryLabel.Text = GetTotalMemory();
            TypeLabel.Text = GetRAMType();
            SpeedLabel.Text = GetRAMSpeed();
            ChanelLabel.Text = GetChanel();
        }
        public static String GetRAMName()
        {
            ManagementClass mc = new ManagementClass("Win32_PhysicalMemory");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                info = mo.Properties["Name"].Value.ToString();
                break;
            }
            return info;
        }
        public static String GetTotalMemory()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;

            foreach (ManagementObject obj in oCollection)
            {
                mCap = Convert.ToInt64(obj["Capacity"]);
                MemSize += mCap;
            }
            MemSize = (MemSize / 1024) / 1024;
            return MemSize.ToString() + " MB";
        }
        public static String GetRAMType()
        {
            ManagementClass mc = new ManagementClass("Win32_PhysicalMemory");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                info = mo.Properties["DeviceLocator"].Value.ToString();
                break;
            }
            return info;
        }
        public static String GetRAMSpeed()
        {
            ManagementClass mc = new ManagementClass("Win32_PhysicalMemory");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                info = mo.Properties["ConfiguredClockSpeed"].Value.ToString();
                break;
            }
            return info;
        }

        public static String GetChanel()
        {
            int MemSlots = 0;
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery2 = new ObjectQuery("SELECT MemoryDevices FROM Win32_PhysicalMemoryArray");
            ManagementObjectSearcher oSearcher2 = new ManagementObjectSearcher(oMs, oQuery2);
            ManagementObjectCollection oCollection2 = oSearcher2.Get();
            foreach (ManagementObject obj in oCollection2)
            {
                MemSlots = Convert.ToInt32(obj["MemoryDevices"]);

            }
            return MemSlots.ToString();
        }
        public static String GetUsed()
        {
            Computer computer = new Computer() { RAMEnabled = true };
            computer.Open();
            String result = "";
            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();
                foreach (ISensor sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Load)
                    {
                        if (sensor.Value.HasValue)
                        {
                            result = sensor.Value.ToString();
                        }
                        else
                        {
                            result = "NaN";
                        }

                    }
                }
            }
            return result;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UsedLabel.Text = GetUsed() + " %";
            chart1.Series["RAM"].Points.AddY(GetUsed());
            chart1.ChartAreas[0].AxisY.Maximum = 10000000;
        }
    }
}
