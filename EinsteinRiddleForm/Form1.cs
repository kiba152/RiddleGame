using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EinsteinRiddleForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            string Box1 = comboBox4.SelectedItem.ToString();
            string Box2 = comboBox9.SelectedItem.ToString();
            string Box3 = comboBox14.SelectedItem.ToString();
            string Box4 = comboBox19.SelectedItem.ToString();
            string Box5 = comboBox24.SelectedItem.ToString();
            string britNationalityBox = comboBox8.SelectedItem.ToString();
            string dogBox = comboBox25.SelectedItem.ToString();
            //string britHint = label11;
            if (Box1 == "Green" && Box2 == "German" && Box3 == "Coffee" && Box4 == "Prince" && Box5=="Fish")
            {
                resultLabel.ForeColor = System.Drawing.Color.Green;
                resultLabel.Text = "Success";
            }
            else if (britNationalityBox=="Brit" && dogBox=="Dogs")
            {
                label11.BackColor = Color.Blue;
                resultLabel.Text = "Fair";
                resultLabel.ForeColor = Color.Turquoise;
            }
            else
            {
                resultLabel.ForeColor = System.Drawing.Color.Red;
                resultLabel.Text = "Failed";
                //resultLabel.BackColor = Color.Red;
            }
        }

    }
}
