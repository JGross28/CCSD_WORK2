using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02
{
    public partial class Week02 : Form
    {
        Coach c1;
        Coach c2;
        SportTeam football;
        SportTeam tennis;
        public Week02()
        {
            InitializeComponent();

            c1 = new Coach();
            c2 = new Coach();
            c2.FirstName = "Jordan";
            c2.LastName = "Gross";
            c1.FirstName = "Julien";
            c1.LastName = "Esposito";
            football = new SportTeam();
            tennis = new SportTeam();
            tennis.Address = " 1234 Main St, Escondido, CA 92026";
            tennis.Coach = c2;
            tennis.contactInfo = "760-555-2222";
            football.Address = "311, Clementine Street, Oceanside, CA 92054";
            football.Coach = c1;
            football.contactInfo = "760-555-0153";
        }

        private void btnFootball_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Coach " + football.Coach + "\n" + football.Address + "\n" + football.contactInfo;
        }

        private void btnTennis_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Coach " + tennis.Coach + "\n" + tennis.Address + "\n" + tennis.contactInfo;
        }
    }
}
