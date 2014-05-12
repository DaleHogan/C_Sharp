using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IndexerWithWindowsForms
{
    public partial class Form1 : Form
    {
        People people;
        public Form1()
        {
            InitializeComponent();
            ObjectsLoader ol = new ObjectsLoader();
            people = ol.list;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputViewDg.RowHeadersVisible = false;
            statusComboBox.Location = ageTextBox.Location;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputViewDg.Rows.Clear();
            int userSelection = comboBox1.SelectedIndex;
            Label.Visible = true;
            if (userSelection == 0)
            {
                Label.Text = "Age";
                ageTextBox.Visible = true;
             
                statusComboBox.Visible = false;         

            }
            else
            {
                Label.Text = "Status";
                ageTextBox.Visible = false;
                
                statusComboBox.Visible = true;

            }

        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            outputViewDg.Rows.Clear();
            errorAgeLabel.Visible = false;
            try
            {
                int age = Convert.ToInt32(ageTextBox.Text);
                Person[] list = people[age];
                foreach (Person p in list)
                {
                    outputViewDg.Rows.Add(p.LastName.Trim(), p.FirstName, p.Age, p.Address, p.MaritalStatus, String.Format("{0:d}", p.DOB));
                }
            }
            catch (Exception)
            {
                errorAgeLabel.Visible = true;
            }

        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            outputViewDg.Rows.Clear();
            string status = statusComboBox.SelectedItem.ToString();
            Person[] list = people[status];
            foreach (Person p in list)
            {
                outputViewDg.Rows.Add(p.LastName.Trim(), p.FirstName, p.Age, p.Address, p.MaritalStatus, String.Format("{0:d}", p.DOB));
            }
            

        }

       
    }
}
