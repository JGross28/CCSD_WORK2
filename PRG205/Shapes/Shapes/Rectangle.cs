using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double m_l;
        private double m_w;

        public Rectangle(double m_length, double m_width)
        {
            m_l = m_length;
            m_w = m_width;

            m_Area = m_length * m_width;
            m_Volume = 0;
            m_shapeName = "Rectangle";

        }
        

        public override double Area
        {
            get
            {
                return m_Area;
            }
        }

        public override String Name
        {
            get
            {
                return m_shapeName;
            }
        }

        public override double Volume
        {
            get
            {
                return m_Volume;
            }
        }
    }
}
