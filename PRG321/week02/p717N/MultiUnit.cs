using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p717N10
{
    public class MultiUnit : Housing, IUnits
    {
        public MultiUnit()
        {
            m_Address = "987 That One Road";
            m_yearBuilt = 2015;
        }

        public override int NumberUnits()
        {
            return 9;
        }
    }
}
