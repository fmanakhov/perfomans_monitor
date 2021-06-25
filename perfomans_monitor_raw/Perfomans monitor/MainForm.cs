using System;
using System.Windows.Forms;

namespace Perfomans_monitor
{
    public partial class MainForm : Form
    {
        private InfoProgramForm InfoProgramForm_Button;
        private InfoForm InfoForm_Button;
        private CPUForm CPUForm_Button;
        private RAMForm RAMForm_Button;
        private GPUForm2 GPUForm2_Button;
        private DisksForm DisksForm_Button;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void total_info_button1_Click(object sender, EventArgs e)
        {
            if (InfoForm_Button == null)
            {
                InfoForm_Button = new InfoForm();
                InfoForm_Button.Show();
            }
            else
            {
                InfoForm_Button.Close(); //для повторного не открытия
                InfoForm_Button = null;
            }

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(InfoProgramForm_Button == null)
            {
                InfoProgramForm_Button = new InfoProgramForm();
                InfoProgramForm_Button.Show();
            }
            else
            {
                InfoProgramForm_Button.Close(); //для повторного не открытия
                InfoProgramForm_Button = null;
            }
        }

        private void cpu_button2_Click(object sender, EventArgs e)
        {
            if (CPUForm_Button == null)
            {
                CPUForm_Button = new CPUForm();
                CPUForm_Button.Show();
            }
            else
            {
                CPUForm_Button.Close(); //для повторного не открытия
                CPUForm_Button = null;
            }
        }

        private void ram_button3_Click(object sender, EventArgs e)
        {
            if (RAMForm_Button == null)
            {
                RAMForm_Button = new RAMForm();
                RAMForm_Button.Show();
            }
            else
            {
                RAMForm_Button.Close(); //для повторного не открытия
                RAMForm_Button = null;
            }
        }


        private void disks_button5_Click(object sender, EventArgs e)
        {
            if (DisksForm_Button == null)
            {
                DisksForm_Button = new DisksForm();
                DisksForm_Button.Show();
            }
            else
            {
                DisksForm_Button.Close(); //для повторного не открытия
                DisksForm_Button = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=GPbdazXpRsw&list=PLB4966DCD2AA75A41");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void gpu_button_2_Click(object sender, EventArgs e)
        {
            if (GPUForm2_Button == null)
            {
                GPUForm2_Button = new GPUForm2();
                GPUForm2_Button.Show();
            }
            else
            {
                GPUForm2_Button.Close(); //для повторного не открытия
                GPUForm2_Button = null;
            }
        }
    }
}