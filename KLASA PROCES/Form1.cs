using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KLASA_PROCES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonExplorer_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
        }

        private void buttonStartInfo_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("iexplore.exe");
            startInfo.Arguments = "http://www.sser.hr";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(startInfo);

            ProcessStartInfo startInfo2 = new ProcessStartInfo("winword.exe");
            startInfo.Arguments = "http://www.sser.hr";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(startInfo2);

            ProcessStartInfo startInfo3 = new ProcessStartInfo("excel.exe");
            startInfo.Arguments = "http://www.sser.hr";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(startInfo3);

            ProcessStartInfo startInfo4 = new ProcessStartInfo("notepad.exe");
            startInfo.Arguments = "http://www.sser.hr";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(startInfo4);
        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            Process.Start("winword.exe");
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            Process.Start("excel.exe");
        }

        private void buttonNotepad_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }
    }
}
