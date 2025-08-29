using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace L10Work
{
    class Angle
    {
        int gradus;
        int minute;
        int second;
        bool direction = true;     //  Введём направление, против часовой - true(положительный угол), по - false(отрицательный)

        public int Gradus       //  Учитывая запись градусы°минуты'секунды" - знак оставляем только у градусов как направление угла.
        {
            get
            {
                return gradus;
            }
            set
            {
                if (value < 0)      
                {
                    value = Math.Abs(value);        //  Берём градусы по модулю, чтобы прибавлять минуты и секунды. Должно сработать.
                    direction = false;      //  Укажем направление
                }
                if (value > 360) gradus = value % 360;      //  Если введено больше полного оборота - интересует только остаток.
                else gradus = value;
            }
        }

        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                Gradus += value / 60;
                minute = value % 60;
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                Minute += value / 60;
                second = value % 60;
            }
        }

        public Angle(int gradus, int minute, int second)
        {
            this.Gradus = gradus;
            this.Minute = minute;
            this.Second = second;
        }

        public double ToRadians()
        {
            if(direction) return (gradus + minute / 60 + second / 3600) * Math.PI / 180;        //  Положительный угол
            else return -((gradus + minute / 60 + second / 3600) * Math.PI / 180);      //  Отрицательный угол. Возможно, стоит вернуть direction=true после.
        }
    }



}
