using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Week_1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void m_btn_ClickMe_Click(object sender, EventArgs e)
        {//Code that reacts to onclick event
            string firstName = m_tb_First_Name.Text;
            if (string.IsNullOrEmpty(firstName))
            {
                return;
            }
            string greeting = "Hello " + firstName;
            m_lbl_feedback.Text = greeting;
        }
    }
}
