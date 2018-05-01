using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Cylinder : Shape
    {
        protected double m_h;
        protected double m_r;
        public Cylinder(double m_height, double m_radius)
        {
            m_h = m_height;
            m_r = m_radius;

            m_Area = m_height * m_radius;
            m_Volume = Math.PI * (m_radius * m_radius) * m_height;
            m_shapeName = "Cylinder";


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
