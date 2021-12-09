using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace UoH_Navigation_2
{
    public partial class Form1 : Form
    {
        List<string> building;
        List<string> room;
        List<string> directions;
        List<string> whereFrom;

        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("roomDirections.csv");
            building = new List<string>();
            room = new List<string>();
            directions = new List<string>();
            whereFrom = new List<string>();

            string line;
            while((line = sr.ReadLine()) != null)
            {
                string[] columns = line.Split(',');
                building.Add(columns[0]);
                room.Add(columns[1]);
                directions.Add(columns[2]);
                whereFrom.Add(columns[3]);
            }
            building.RemoveAt(0);

            selection1.Items.AddRange(building.Distinct().ToArray());

            foreach (string place in room)
            { 
                selection2.Items.Add(place);
            }
        }


        



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void selection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selection2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int choice = selection2.SelectedIndex;
            MessageBox.Show(directions[choice]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
