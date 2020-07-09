using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Agency
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new EmployeeForm().Show();
            Visible = true;
            ShowInTaskbar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Klient().Show();
            Visible = true;
            ShowInTaskbar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Type_Of_Weapon().Show();
            Visible = true;
            ShowInTaskbar = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Object().Show();
            Visible = true;
            ShowInTaskbar = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Nakladnaya().Show();
            Visible = true;
            ShowInTaskbar = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Weapon().Show();
            Visible = true;
            ShowInTaskbar = true;
        }
    }
}
