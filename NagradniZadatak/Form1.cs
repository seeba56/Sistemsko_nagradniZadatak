using System.Diagnostics;
using System;
using System.Threading;

namespace NagradniZadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void OtvoriPaint_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("mspaint.exe");
            OtvoriPaint.Enabled = false;
            process.WaitForExit();
            OtvoriPaint.Enabled = true;
        }

        private void OtvoriNotepad_Click(object sender, EventArgs e)
        {
            Process process = Process.Start("notepad.exe");
            OtvoriNotepad.Enabled = false;
            process.WaitForExit();
            OtvoriNotepad.Enabled = true;
        }

        private void OtvoriCmd_Click_1(object sender, EventArgs e)
        {
            Process process = Process.Start("cmd.exe");
            OtvoriCmd.Enabled = false;
            process.WaitForExit();
            OtvoriCmd.Enabled = true;
        }
    }
}