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
    public partial class GPUForm2 : Form
    {
        public GPUForm2()
        {
            InitializeComponent();
            GPUNameLabel.Text = GetGPU2Name();
            TotalMemoryLabel.Text = GetTotalMemory();
            VersionLabel.Text = GetVersion();
            GPULabel.Text = GetGPUName();
        }

        public static string GetGPUName()
        {
            ManagementClass mc = new ManagementClass("Win32_VideoController");
            ManagementObjectCollection moc = mc.GetInstances();
            String NameGPU = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                NameGPU = mo.Properties["Name"].Value.ToString();
                break;
            }
            return NameGPU;
        }
        public static string GetGPU2Name()
        {
            Computer computer = new Computer() { GPUEnabled = true };
            computer.Open();
            String result = "";
            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();
                result = hardware.Name;
            }
            return result;

        }

        public static String GetTotalMemory()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT AdapterRAM FROM Win32_VideoController");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;

            foreach (ManagementObject obj in oCollection)
            {
                mCap = Convert.ToInt64(obj["AdapterRAM"]);
                MemSize += mCap;
            }
            MemSize = (MemSize / 1024) / 1024;
            return MemSize.ToString() + " МБ";
        }

        public static String GetVersion()
        {
            ManagementClass mc = new ManagementClass("Win32_VideoController");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                info = mo.Properties["DriverVersion"].Value.ToString();
            }
            return info;
        }

        public static String GetGPUClockSpeed()
        {
            Computer computer = new Computer() { GPUEnabled = true };
            computer.Open();
            String result = "";
            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();
                foreach (ISensor sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Clock)
                    {
                        if (sensor.Value.HasValue)
                        {
                            result = sensor.Value.ToString();

                            return result;
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

        public static String GetTemperature()
        {
            Computer computer = new Computer() { GPUEnabled = true };
            computer.Open();
            String result = "";
            foreach (IHardware hardware in computer.Hardware)
            {
                hardware.Update();
                foreach (ISensor sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature)
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
        public static String GetUsed()
        {
            Computer computer = new Computer() { GPUEnabled = true };
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

        public static String GetUsedMemory()
        {
            Computer computer = new Computer() { GPUEnabled = true };
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
                        break;
                    }
                }
            }
            return result;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            FrequencyLabel.Text = GetGPUClockSpeed() + " ГЦ";
            TemperatureLabel.Text = GetTemperature() + " °C";
            UsedLabel.Text = GetUsed() + " %";
            UsedMemoryLabel.Text = GetUsedMemory() + " МБ";
            chart1.Series["GPU"].Points.AddY(GetUsed());
            chart1.ChartAreas[0].AxisY.Maximum = 1000000;
        }
    }
}
