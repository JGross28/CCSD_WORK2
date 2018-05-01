using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<h1 style = \"color: blue;\">Hello, welcome to this page.</h1>");
        }

        protected void m_btnOne_Click(object sender, EventArgs e)
        {
            string shoppingList = m_tbOne.Text;
            if (string.Empty == shoppingList)
            {
                Response.Write("Please Enter an Item for the Shopping List:");
            }
            else
            {
                ListBox1.Items.Add(shoppingList);
            }
            m_tbOne.Text = string.Empty;
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDisplay.Text = ListBox1.SelectedItem.Text;
        }

    }
}