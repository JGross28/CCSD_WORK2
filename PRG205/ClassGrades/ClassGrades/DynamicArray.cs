using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassGrades
{
    public class DynamicArray
    {
        private double[] dataArray;
        private int m_NumberofValuesAppended;
        private double min;
        private double max;

        public DynamicArray()//default constructor
        {
            dataArray = new double[1];
            m_NumberofValuesAppended = 0;
        }

        void AppendNewValue(double v)
        {
            int old_Array = dataArray.Length;
            if (m_NumberofValuesAppended <= dataArray.Length)
            {
                dataArray[m_NumberofValuesAppended - 1] = v;
            }
            else
            {
             //save m_Array to a temp array,save
             // reallocate m_Array to be one block bigger
             //copy save array back to m_Array
             //increment the variable m_NumberofValuesAppended 
            }
        }
        void MinValue()
        {
            double min = dataArray[0];
            for (int i = 0; i < dataArray.Length; i++)
            {
                if (dataArray[i] <= min)
                {
                    min = dataArray[i];
                }
            }
        }
        void MaxValue()
        {
            double max = dataArray[0];
            for (int i = 0; i < dataArray.Length; i++)
            {
                if (dataArray[i] >= max)
                {
                    max = dataArray[i];
                }
            }
        }
    }
}
