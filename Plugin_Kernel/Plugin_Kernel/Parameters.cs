using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin_Kernel
{
     public class Parameters
    {
        /// <summary>
        /// параметр: радиус нижней части детали 
        /// </summary>
        public double Radios1
        {
            get;
            set;
        }

        /// <summary>
        /// параметр: радиус верхней части детали
        /// </summary>
        public double Radios2
        {
            get;
            set;
        }

        /// <summary>
        /// параметр: длина нижней части детали
        /// </summary>
        public double Lenght1
        {
            get;
            set;
        }

        /// <summary>
        /// параметр: длина верхней части детали
        /// </summary>
        public double Lenght2
        {
            get;
            set;
        }

        /// <summary>
        /// параметр: угол выдавливания средней части детали
        /// </summary>
        public double Angle1
        {
            get;
            set;
        }

        /// <summary>
        /// параметр: длина фаски на верхней части детали
        /// </summary>
        public double Angle2
        {
            get;
            set;
        }

        /// <summary>
        /// расчет координат, при отсечении части детали на нажнем цилиндре
        /// </summary>
        public double Cut1
        {
            get
            {
                return Radios1 / 2;
            }
        }

        /// <summary>
        /// расчет длины, при вырезании части детали на нижнем цилиндре
        /// </summary>
        public double Cut2
        {
            get
            {
                return Lenght1 - (Lenght1 / 5);
            }
        }
    }
}
