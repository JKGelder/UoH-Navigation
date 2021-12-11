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
        public List<string> directions;
        List<string> whereFrom;
        List<string> floor;
        public static string whereFromS;
        public static string pubDirections;

        public Form1()
        {
            
            
            InitializeComponent();
            StreamReader sr = new StreamReader("roomDirections.csv");
            building = new List<string>();
            room = new List<string>();
            directions = new List<string>();
            whereFrom = new List<string>();
            floor = new List<string>();

            string line;
            while((line = sr.ReadLine()) != null)
            {
                string[] columns = line.Split(',');
                building.Add(columns[0]);
                room.Add(columns[1]);
                directions.Add(columns[2]);
                whereFrom.Add(columns[3]);
                floor.Add(columns[4]);
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

        public void selection2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int choice = selection2.SelectedIndex;
            
            //if disability option is ticked, check if destination is upstairs, ask user if they need directions to the lift
            int floorChoice = int.Parse(floor[choice]);
            if (floorChoice > 0 && Form3.stairDifficulty == true)
            {
                MessageBox.Show("This room is not on the ground floor." + "\n" +
                    "If you need directions to the lift, they are in the get directions list.");
            }

            
                
            pubDirections = directions[choice];
            whereFromS = whereFrom[choice];
            Form2 f2 = new Form2();
            f2.ShowDialog();
                                               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
