using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2Assignment2
{
    public class ProfessorRating
    {

        // all variables below are member variables
        private double m_easiness;
        private double m_helpfullness;
        private double m_courseMaterial;
        private int m_id;

        // constructors never have a return type
        public  ProfessorRating(int professor_id)
        {
            m_id = professor_id;
        }

        public  double OverallRating()
        {
            double OverallRating;
            OverallRating = (m_easiness + m_helpfullness + m_courseMaterial) / 3;
            return OverallRating;
        }

        // this is a property (AKA a glorified method)
        // which has an inpact on the member variable 
        // "m_helpfullness"
        public double HelpFullness
        {
            set { m_helpfullness = value; }
            get { return m_helpfullness; }
        }

        public double EasiNess
        {
            set { m_easiness = value; }
            get { return m_easiness; }
        }

        public double CourseMaterial
        {
            set { m_courseMaterial = value; }
            get { return m_courseMaterial; }
        }

        // overriding VS-generated Default constructor
        private ProfessorRating()
        {
        }

        public int id
        {
            // per the assignment, once a ProfessorRating
            // is instanciated, it should impossible to change/set
            // its id. Therefore, in the ID property, we disable 
            // the setter.
            //set
            //{
            //    m_id = value;
            //}
            get
            {
                return m_id;
            }
        }
    }
}
