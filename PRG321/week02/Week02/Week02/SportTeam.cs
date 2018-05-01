using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week02
{
    public class SportTeam
    {
        protected string m_address;
        protected Coach m_coach;
        protected string m_contactInfo;

        public Coach Coach
        {
            get
            {
                return m_coach;
            }
            set
            {
                m_coach = value;
            }
        }

        public string Address
        {
            get
            {
                return m_address;
            }
            set
            {
                m_address = value;
            }
        }
        public string contactInfo
        {
            get
            {
                return m_contactInfo;
            }
            set
            {
                m_contactInfo = value;
            }
        }

        public virtual String ShowClassName()
        {
            String s = "SportTeam";
            return s;
        }
    }
}