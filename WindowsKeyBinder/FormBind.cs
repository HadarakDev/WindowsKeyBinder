using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsKeyBinder
{
    public partial class FormBind : Form
    {
        IKeyboardMouseEvents MouseHook;
        bool IsKeySet;

        public FormBind()
        {
            InitializeComponent();
            MouseHook = Hook.GlobalEvents();
            MouseHook.MouseDownExt += GlobalHookMouseDownExt;
            IsKeySet = false;
        }


        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            
            if (IsKeySet == false && !e.Button.ToString().Equals("Left") && !e.Button.ToString().Equals("Right"))
            {
                IsKeySet = true;
                KeyLabel.Text = e.Button.ToString();
            }
        }


        private void SetApplicationButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ApplicationLabel.Text = openFileDialog1.FileName;
            }
        }

        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            MainForm.SetApplication = ApplicationLabel.Text;
            MainForm.SetKey = KeyLabel.Text;
            Program.Form.RefreshBind();
            this.Hide();
            this.Dispose();
        }
    }
}
