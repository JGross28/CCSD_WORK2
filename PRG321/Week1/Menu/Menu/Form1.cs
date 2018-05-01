using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Display_Click(object sender, EventArgs e)
        {
            string first = tbFirst.Text;
            string last = tbLast.Text;
            string email = tbEmail.Text;
            string address = tbAddress.Text;
            int phone = Convert.ToInt32(tbPhone.Text);
            if (tbPhone.Text.Length > 7)
            {
                MessageBox.Show("Phone too long. Enter 7 digits");
            }
            if (!int.TryParse(tbPhone.Text, out phone))
            {
                MessageBox.Show("Please enter a valid phone number");
            }
            string feedback = "Hello, " + first + " " + last + "\n" + email + "\n" + address + "\n" + phone;
            lblFeedback.Text = feedback;

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbFirst.Text = "";
            tbLast.Text = "";
            tbEmail.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
            lblFeedback.Text = "";
        }

        private void Exit_Application(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
