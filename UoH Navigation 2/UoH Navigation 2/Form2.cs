using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UoH_Navigation_2
{
    public partial class Form2 : Form
    {
        int i = 0;
        string[] splitDirections = Form1.pubDirections.Split(';');
        public Form2()
        {
            InitializeComponent();
            
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Form1.whereFromS;
            //textBox1.Text = splitDirections[i];
            try
            {
                textBox1.Text = splitDirections[i];
                i++;
            }
            catch
            {

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
