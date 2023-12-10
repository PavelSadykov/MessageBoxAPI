using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBoxApp
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
        string name = "";
        string occupation = "";
        string location = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            name = textBoxName.Text;
            occupation = textBoxJob.Text;
            location = textBoxCity.Text;

            MessageBox(IntPtr.Zero, name, "Ваше имя :", 0);
            MessageBox(IntPtr.Zero, occupation, "Ваша профессия :", 0);
            MessageBox(IntPtr.Zero, location, "Ваше местонахождение :", 0);
        }
    }
}

