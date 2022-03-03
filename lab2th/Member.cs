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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }
        //обращение к главной форме
        public Member(AirportForm f)
        {
            InitializeComponent();
          
        }

        
        AirportClass airportClass = new AirportClass();

        private void add_info_Click(object sender, EventArgs e)
        {
            airportClass.AddName(name_surname);
            this.Close();
        }

        private void Age_Scroll(object sender, EventArgs e)
        {
            airportClass.CheackSeats(textBox1, Age);
        }
    }
 
}
