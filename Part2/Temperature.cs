using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Temperature
    {
        private float temper;
        private char scale;

        public Temperature()
        {
            temper = 0;
            SetScaleC();
        }
        public Temperature(float t)
        {
            temper = t;
            SetScaleC();
        }
        public Temperature(char s)
        {
            temper = 0;
            if (s == 'F')
            {
                SetScaleF();
            }
            else
            {
                SetScaleC();
            }
        }
        public Temperature(float t, char s)
        {
            temper = t;
            if (s == 'F')
            {
                SetScaleF();
            }
            else
            {
                SetScaleC();
            }
        }

        public float GetTempC()
        {
            if (scale == 'F')
            {
                return (float)Math.Round(((temper - 32) * 5 / 9), 1);
            }
            else
            {
                return temper;
            }
        }

        public float GetTempF()
        {
            if (scale == 'C')
            {
                return (float)Math.Round((((temper / 9) * 5) + 32), 1);
            }
            else
            {
                return temper;
            }
        }

        public void SetScaleF()
        {
            scale = 'F';
        }

        public void SetScaleC()
        {
            scale = 'C';
        }

        public void SetTemp(float t)
        {
            temper = t;
        }

        public void SetTemp(float t, char s)
        {
            temper = t;
            if (s == 'F' || s == 'C')
            {
                scale = s;
            }
            else
            {
                scale = 'C';
            }

        }

        public bool Equals(Temperature other)
        {
            if (this.GetTempC() == other.GetTempC())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public override string ToString()
        {
            return "" + (float)Math.Round(temper, 1) + " degrees " + scale;
        }
    }
}
