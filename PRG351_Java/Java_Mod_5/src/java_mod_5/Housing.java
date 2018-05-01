
package java_mod_5;

public class Housing implements iUnits {
        protected int m_yearBuilt;
        protected String m_Address;

        public Housing()
        {
            m_yearBuilt = 1980;
            m_Address = "234 Main St";
        }
        
        public Housing( int year, String address)
        {
            m_yearBuilt = year;
            m_Address = address;
        }

        @Override 
        public int NumberUnits()
        {
            return 4;
        }
        
        //@Override To String is never defined in any parent class
        // Therefore it is non-sesical to attempt at redefining the 
        // behavior of ToString()
        public String ToString()
        {
            String s = "Year built = " + m_yearBuilt + " - Address = " + m_Address;
            return s;
        }
        
        public double GetRentalAmount()
        {
            return 1565.5;
        }
}
