using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsKeyBinder
{
    public partial class MainForm : Form
    {
        public static string SetKey;
        public static string SetApplication;
        IKeyboardMouseEvents MouseHook;
        private Dictionary<String, String> BindDictionary = new Dictionary<String, String>();

        public MainForm()
        {
            InitializeComponent();


            String columns = "{0, -20}{1, -20}";
            label1.Text = (String.Format(columns, "Key", "Application"));
            MouseHook = Hook.GlobalEvents();
            MouseHook.MouseDownExt += DetectMouseInput;
        }


        private void DetectMouseInput(object sender, MouseEventExtArgs e)
        {
            String Application = "";
            BindDictionary.TryGetValue(e.Button.ToString(), out Application);
            if (Application != null && Application.Contains(".exe"))
            {
                Debug.WriteLine("start process");
                Process.Start(Application);
            }
        }


        private void AddBind_Click(object sender, EventArgs e)
        {            
            FormBind TempForm = new FormBind();
            TempForm.Show();
        }

        public  void RefreshBind()
        {
            String columns = "{0, -20}{1, -20}";
            if (BindDictionary.ContainsKey(SetKey))
            {
                BindListBox.Items.Remove(String.Format(columns, SetKey, BindDictionary[SetKey]));
                BindDictionary[SetKey] = SetApplication;
                BindListBox.Items.Add(String.Format(columns, SetKey, SetApplication));

            }
            else
            {
                BindDictionary.Add(SetKey, SetApplication);
                BindListBox.Items.Add(String.Format(columns, SetKey, SetApplication));
            }
        }

        private void RemoveBind_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BindListBox.CheckedItems.Count; i++)
            {
                String columns = "{0, -20}{1, -20}";
                string key = ((String)BindListBox.CheckedItems[i]).Split(' ')[0];
                BindListBox.Items.Remove(String.Format(columns, key, BindDictionary[key]));
                BindDictionary.Remove(key);
            }

        }
    }
} 
