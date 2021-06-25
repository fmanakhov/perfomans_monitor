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
    public partial class CPUForm : Form
    {
        public CPUForm()
        {
            InitializeComponent();
            CPUNameLabel.Text = GetProcessorName();
            CoreLabel.Text = GetProcessorCore();
            ThreadLabel.Text = GetProcessorThread();
            CacheLabelL2.Text = "L2: " + GetProcessorCacheL2() + " КБ";
            CacheLabelL3.Text = "L3: " + GetProcessorCacheL3() + " КБ";
        }
        public static String GetProcessorName()
        {
            ManagementClass mc = new ManagementClass("Win32_Processor"); // указываем, какой WMI раздел необходим нам.
            ManagementObjectCollection moc = mc.GetInstances(); // получения доступа к WMI.
            String NameCPU = String.Empty; // создание переменной String, в которую запишется нужный параметр.
            foreach (ManagementObject mo in moc) // через цикл ищем нужный нам параметр.
            {
                NameCPU = mo.Properties["Name"].Value.ToString(); // присваиваем переменной String, нужный нам параметр.
                break; // после присвоение нужного параметра, выходим из цикла, чтоб не нагружать программу.
            }
            return NameCPU; // возвращаем значения.
        }

        public static String GetProcessorCore()
        {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String CoreCPU = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                CoreCPU = mo.Properties["NumberOfCores"].Value.ToString();
                break;
            }
            return CoreCPU;
        }

        public static String GetProcessorThread()
        {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String ThreadCPU = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                ThreadCPU = mo.Properties["NumberOfLogicalProcessors"].Value.ToString();
                break;
            }
            return ThreadCPU;
        }

        public static String GetProcessorCacheL2()
        {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String L2CPU = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                L2CPU = mo.Properties["L2CacheSize"].Value.ToString();
                break;
            }
            return L2CPU;
        }
        public static String GetProcessorCacheL3()
        {
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String L3CPU = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                L3CPU = mo.Properties["L3CacheSize"].Value.ToString();
                break;
            }
            return L3CPU;
        }

        public static String GetCPUCurrentClockSpeed()
        {
            Computer computer = new Computer() { CPUEnabled = true }; // создание локальной переменной, включения нужной компонента компьютера.
            computer.Open(); // получения доступа к нужной компонента компьютера.
            String result = ""; // создание переменной String, в которую запишется нужный параметр датчика.
            foreach (IHardware hardware in computer.Hardware) // поиск нужного компонента компьютера.
            {
                hardware.Update(); // обновлять параметры нужного компонента компьютера.
                foreach (ISensor sensor in hardware.Sensors) // поиск датчиков.
                {
                    if (sensor.SensorType == SensorType.Clock) // поиск нужного датчика.
                    {
                        if (sensor.Value.HasValue) // если есть значения датчика, выводить.
                        {
                            result = sensor.Value.ToString();

                            return result;
                        }
                        else // если нет значения датчика, выводить "NaN".
                        {
                            result = "NaN";
                        }
                        break; // после присвоение нужного параметра, выходим из цикла, чтоб не нагружать программу.
                    }
                } break; // после присвоение нужного параметра, выходим из цикла, чтоб не нагружать программу.
            }
            return result; // возвращаем значения.
        }

        public static String GetTemperature()
        {
            Computer computer = new Computer() { CPUEnabled = true };
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
            Computer computer = new Computer() { CPUEnabled = true };
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FrequencyLabel.Text = GetCPUCurrentClockSpeed() + " ГЦ";
            TemperatureLabel.Text = GetTemperature() + " °C";
            UsedLabel.Text = GetUsed() + " %";

            float fcpu = pCPU.NextValue();
            chart1.Series["CPU"].Points.AddY(fcpu);
        }
    }
}
