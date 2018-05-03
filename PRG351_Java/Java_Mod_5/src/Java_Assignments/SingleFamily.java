
package Java_Assignments;

/**
 *
 * @author CCSDuser
 */
public class SingleFamily extends Housing implements iUnits 
{
        private double m_SqrFootage;
        private boolean m_Garage;

        public void SetSquareFootage(double sqr)
        {
            m_SqrFootage = sqr;
        }
        public double GetSquareFootage()
        {
            return m_SqrFootage;
        }

        public void SetGarage(boolean value)
        {
            m_Garage = value;
        }
        
        public boolean GetGarage()
        {
            return m_Garage;
        }

        @Override
        public String ToString()
        {
            String new_Content = " - Square Footage = " + m_SqrFootage + " - Garage = ";
            if( m_Garage == true)
            {
                new_Content += " availabe";
            }
            else
            {
                new_Content += " Not Available";
            }
            return new_Content;
        }
}
