using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab2th
{
    public partial class AirportForm : Form
    { 
        AirportClass airportClass = new AirportClass();
        public AirportForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            airportClass.Print(listBox1, id, radioButton1,radioButton2, radioButton3, checkBox1, checkBox2,checkBox3, dateTimePicker1, Year, model, crew, spase);
            
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            airportClass.Clean(listBox1, id, radioButton1, radioButton2, radioButton3, checkBox1, checkBox2, checkBox3, dateTimePicker1, Year, model, crew, spase);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            airportClass.AddXML(listBox1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            airportClass.GetFromXML(label10);
        }
       
        private void Add_Click(object sender, EventArgs e)
        { 
            Member newForm = new Member();
            newForm.Show();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            airportClass.Update(crew);
        }

        private void spase_Scroll(object sender, EventArgs e)
        {
            airportClass.CheackSeats(textBox1, spase);
        }
    }
}
