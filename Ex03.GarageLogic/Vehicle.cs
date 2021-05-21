using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    abstract class Vehicle
    {
        internal class Wheel
        {
            private readonly string mr_ManufactureName;
            private float m_CurAirPressure;
            private float m_MaxAirPressure;

            internal Wheel(string i_ManufactureName, float i_CurAirPressure, float i_MaxAirPressure)
            {
                if (i_CurAirPressure > i_MaxAirPressure || i_CurAirPressure < 0)
                {
                    throw new ValueOutOfRangeException(i_MaxAirPressure, 0);
                }
                else
                {
                    this.mr_ManufactureName = i_ManufactureName;
                    this.m_CurAirPressure = i_CurAirPressure;
                    this.m_MaxAirPressure = i_MaxAirPressure;
                }
            }

            /*
             * Inflate the wheel method
             * input = -1 to fill the wheel to its max air pressure
             * Throws ValueOutOfRangeException when the input is out of range
            */
            private void inflate(float i_AirToAdd)
            {
                if (i_AirToAdd == -1)
                {
                    m_CurAirPressure = m_MaxAirPressure;
                }
                else if (i_AirToAdd + m_CurAirPressure > m_MaxAirPressure || i_AirToAdd < 0)
                {
                    throw new ValueOutOfRangeException(0, m_MaxAirPressure);
                }
                else
                {
                    m_CurAirPressure += i_AirToAdd;
                }
            }

            private string toString()
            {
                string wheelToString = string.Format(@"Manufacturer Name:  {0}
                                                        Maximum Air Pressure: {1}
                                                        Current Air Pressure: {2}"
                                                        , mr_ManufactureName, m_MaxAirPressure, m_CurAirPressure);
                return wheelToString;
            }
        }

        protected readonly string mr_ModelName;
        protected readonly string mr_LicensePlateNumber;
        protected float m_EnergyPrecent;
        protected readonly bool mvr_IsFuelBased;
        protected Wheel[] m_Wheels;

        public Vehicle(string i_ModelName, string i_LicensePlateNumber, float i_EnergyPrecent, bool i_IsFuelBased)
        {

        }
    }
}
