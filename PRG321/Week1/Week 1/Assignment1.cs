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
    public partial class Assignment1 : Form
    {
        public Assignment1()
        {
            InitializeComponent();
        }

        private void m_btnAdd_Click(object sender, EventArgs e)
        {
            string in1 = m_tb1stInput.Text;
            string in2 = m_tb2ndInput.Text;
            if (string.IsNullOrEmpty(in1))
            {
                return;
            }
            if (string.IsNullOrEmpty(in2))
            {
                return;
            }
            double input1 = Convert.ToDouble(m_tb1stInput.Text);
            double input2 = Convert.ToDouble(m_tb2ndInput.Text);
            string answer = Convert.ToString(input1 + input2);
            m_lblFeedback.Text = answer;
        }

        private void m_btnMultiply_Click(object sender, EventArgs e)
        {
            string in1 = m_tb1stInput.Text;
            string in2 = m_tb2ndInput.Text;
            if (string.IsNullOrEmpty(in1))
            {
                return;
            }
            if (string.IsNullOrEmpty(in2))
            {
                return;
            }
            double input1 = Convert.ToDouble(m_tb1stInput.Text);
            double input2 = Convert.ToDouble(m_tb2ndInput.Text);
            string answer = Convert.ToString(input1 * input2);
            m_lblFeedback.Text = answer;
            
        }

        private void Clear_Entries(object sender, EventArgs e)
        {
            m_tb1stInput.Text = "";
            m_tb2ndInput.Text = "";
            m_lblFeedback.Text = "";

        }

        private void Exit_Application(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
