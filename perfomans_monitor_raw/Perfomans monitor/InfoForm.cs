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
    public partial class InfoForm : Form
    {
        public static string GetOSInformation()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return ((string)wmi["Caption"]).Trim() + ", " + (string)wmi["Version"] + ", " + (string)wmi["OSArchitecture"];
                }
                catch { }
            }
            return "BIOS Maker: Unknown";
        }
        public static String GetProcessorName()
        {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String NameCPU = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                NameCPU = mo.Properties["Name"].Value.ToString();
                break;
            }
            return NameCPU;
        }
        public static string GetPhysicalMemory()
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
            return MemSize.ToString() + "MB";
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
        public static string GetDisksName()
        {
            ManagementClass mc = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection moc = mc.GetInstances();
            String NameDisks = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                NameDisks = mo.Properties["Caption"].Value.ToString();
            }
            return NameDisks;
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
        public InfoForm()
        {
            InitializeComponent();
            OSLabel.Text = GetOSInformation();
            CPULabel.Text = GetProcessorName();
            RAMLabel.Text = "Обьём: " + GetPhysicalMemory();
            GPULabel.Text = GetGPUName();
            GPULabel2.Text = GetGPU2Name();
            DisksLabel.Text = GetDisksName();
        }
    }
}
