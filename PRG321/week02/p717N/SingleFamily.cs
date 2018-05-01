using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p717N10
{
    public class SingleFamily : Housing, IUnits
    {
        private double m_SqrFootage;
        private bool m_Garage;

        public double SquareFootage
        {
            set { m_SqrFootage = value; }
            get { return m_SqrFootage; }
        }

        public bool GarageAvailable
        {
            set { m_Garage = value; }
            get { return m_Garage; }
        }

        public override string ToString()
        {
            String old_Content = base.ToString();
            String new_Content = " - Square Footage = " + m_SqrFootage + " - Garage = ";
            if( m_Garage == true)
            {
                new_Content += " availabe";
            }
            else
            {
                new_Content += " Not Available";
            }
            return old_Content + new_Content;
        }
    }
}
