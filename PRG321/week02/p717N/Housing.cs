using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p717N10
{
    public class Housing : IUnits
    {
        protected int m_yearBuilt;
        protected string m_Address;

        public Housing()
        {
            m_yearBuilt = 1980;
            m_Address = "234 Main St";
        }

        virtual public int NumberUnits()
        {
            return 4;
        }

        public override string ToString()
        {
            String s = "Year built = " + m_yearBuilt + " - Address = " + m_Address;
            return s;
        }

        public virtual double GetRentalAmount()
        {
            return 1565.5;
        }
    }
}
