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
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;

namespace Perfomans_monitor
{
    public partial class DisksForm : Form
    {
        public DisksForm()
        {
            InitializeComponent();
            HDDNameLabel.Text = GetDisksName();
            TotalMemoryLabel.Text = GetTotalMemory();
            SerialNumberLabel.Text = GetSerialNumber();
            PartitionsLabel.Text = GetPartitions();
            VersionLabel.Text = GetVersion();
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
        public static String GetTotalMemory()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Size FROM Win32_DiskDrive");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;

            foreach (ManagementObject obj in oCollection)
            {
                mCap = Convert.ToInt64(obj["Size"]);
                MemSize += mCap;
            }
            MemSize = ((MemSize / 1024) / 1024) / 1024;
            return MemSize.ToString() + " ГБ";
        }
        public static string GetSerialNumber()
        {
            ManagementClass mc = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection moc = mc.GetInstances();
            String NameDisks = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                NameDisks = mo.Properties["SerialNumber"].Value.ToString();
            }
            return NameDisks;
        }

        public static string GetVersion()
        {
            ManagementClass mc = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection moc = mc.GetInstances();
            String NameDisks = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                NameDisks = mo.Properties["InterfaceType"].Value.ToString();
            }
            return NameDisks;
        }
        public static string GetPartitions()
        {
            ManagementClass mc = new ManagementClass("Win32_DiskPartition");
            ManagementObjectCollection moc = mc.GetInstances();
            String NameDisks = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                NameDisks = mo.Properties["Name"].Value.ToString();
            }
            return NameDisks;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pHDD.NextValue();
            UsedLabel.Text = fcpu + " %";
            chart1.Series["HDD"].Points.AddY(fcpu);
        }
    }
}
