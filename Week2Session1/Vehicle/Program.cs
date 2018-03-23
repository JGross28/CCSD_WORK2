using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicles 
{
    public partial class Vehicle
    {
        private int m_numWheels;
        private string m_typeEngine;
        
        public Vehicle()
        {
            m_numWheels = 4;
            m_typeEngine = "V6";
        }

        public int NumberWheels //use in 3rd party code
        {
            set //property write
            {
                if (value < 4)
                {
                    return;
                }
                else
                {
                    m_numWheels = value;
                }
            }
            get //property read
            {
                return m_numWheels;
            }
        }
    
    }
}
