using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13Work
{
   sealed class MultiBuilding : Building        //  Запечатали, сделав ненаследуемым.
    {
        int floors;
        public MultiBuilding(string adress, int length, int width, int height, int floors)
            : base(adress, length, width, height)
        {
            this.Floors = floors;
        }
        public int Floors
        {
            get
            {
                return floors;
            }
            set     //  Договоримся, что если этажей 0 - это тоже 1 этаж.
            {
                if (value == 0)
                    floors = 1;
                else
                    floors = value;
            }
        }
        public string Print()
        {
            return $"{base.Print()} , всего этажей - {floors}."; 
        }
    }
}
