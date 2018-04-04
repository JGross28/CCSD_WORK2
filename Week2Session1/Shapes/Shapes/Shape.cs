using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public abstract class Shape
    {
        protected string m_shapeName;
        protected double m_Area;
        protected double m_Volume;

        public Shape()
        {
            m_shapeName = "Shape";
            m_Area = 0;
            m_Volume = 0;
        }

        public virtual double Area
        {
            get
            {
                throw new System.NotImplementedException();
}
        }

        public virtual double Volume
        {
            get
            {
                return m_Volume;
}
        }

        public virtual String Name 
        {
            get
            {
                return m_shapeName;
            }
        }
    }
}
