using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double m_x;
        private double m_y;
        private double m_radius;
    
        public Circle(double x_center, double y_center, double Radius)
        {
            m_x = x_center;
            m_y = y_center;
            m_radius = Radius;

            m_Area = Math.PI * m_radius * m_radius;
            m_Volume = 0;
            m_shapeName = "Circle";
        }

        public override double Area
        {
            get
            {
                return m_Area;
            }
        }

        public override string Name
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
