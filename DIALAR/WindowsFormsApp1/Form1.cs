using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public StreamReader R = new StreamReader("C:\\Users\\Administrator\\Desktop\\DIALAR\\Dialar1.txt");
        public String[] RSource = { };


        
        


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font("bold",40);
            label1.Text = R.ReadLine();
    
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
