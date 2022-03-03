using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab2th
{
    internal class AirportClass
    {
        public void Print (ListBox listBox1, MaskedTextBox id, RadioButton radioButton1,
            RadioButton radioButton2, RadioButton radioButton3,CheckBox checkBox1, CheckBox checkBox2, 
            CheckBox checkBox3, DateTimePicker dateTimePicker1, ComboBox Year,ComboBox model, ComboBox crew, TrackBar spase )
        {
            listBox1.Items.Add(id.Text);
            if (radioButton1.Checked == true)
            {
                listBox1.Items.Add(radioButton1.Text);
            }
            if (radioButton2.Checked == true)
            {
                listBox1.Items.Add(radioButton2.Text);
            }
            if (radioButton3.Checked == true)
            {
                listBox1.Items.Add(radioButton3.Text);
            }

            listBox1.Items.Add(model.Text);
            listBox1.Items.Add(crew.Text);
            listBox1.Items.Add(spase.Value.ToString());

            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add(checkBox1.Text);
            }

            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add(checkBox2.Text);

            }

            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add(checkBox3.Text);

            }
            listBox1.Items.Add(dateTimePicker1.Value.ToString());
            listBox1.Items.Add(Year.Text);
        }

        public void Clean(ListBox listBox1, MaskedTextBox id, RadioButton radioButton1,
            RadioButton radioButton2, RadioButton radioButton3, CheckBox checkBox1, CheckBox checkBox2,
            CheckBox checkBox3, DateTimePicker dateTimePicker1, ComboBox Year, ComboBox model, ComboBox crew, TrackBar spase)
        {
            id.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            listBox1.Items.Clear();
            crew.Text = "";
            spase.Value = spase.Minimum;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            Year.Text = "";
            dateTimePicker1.Value = dateTimePicker1.MaxDate;
        }
        public void AddXML (ListBox listBox1)
        {
            XElement doc2 = new XElement("doc",
            new XElement("txt1", listBox1.Items));
            doc2.Save(@"D:\file.xml");
        }
        public void GetFromXML(Label label)
        {
             XDocument myDoc = XDocument.Load(@"D:\file.xml");
            string s = myDoc.Descendants("txt1").First().Value;
            label.Text = s;
        }

        List<string> listName = new List<string>();
        public void AddName(TextBox text)
        {
            listName.Add(text.Text);
            StreamWriter sw = new StreamWriter(@"D:\test.txt");
            foreach (string s in listName)
            { sw.WriteLine(s); }

            sw.Close();
        }
        public void CheackSeats(TextBox textBox1, TrackBar spase)
        {
            textBox1.Text = String.Format($"{spase.Value}");
        }
        public void Update(ComboBox crew)
        {
            crew.Items.AddRange(File.ReadAllLines(@"D:\test.txt"));
        }
    }
}
