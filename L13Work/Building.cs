using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13Work
{
    class Building
    {
        string adress;
        int length;
        int width;
        int height;

        string Adress
        {
            get
            {
                return adress;
            }
            set     //  Если пустой - пишем адрес не указан.
            {
                if (value == "")
                    adress = "Адрес не указан";
                else
                    adress = value;
            }
        }
        int Length
        {
            get
            {
                return length;
            }
            set     //  Отсекаем отрицательное и нулевое значение, а т.к. у нас тип для простоты целый - то проверяем с единицы
            {
                if (value < 1)
                    length = 1;
                else
                    length = value;
            }
        }
        int Width
        {
            get
            {
                return width;
            }
            set     //  То же самое с шириной.
            {
                if (value < 1)
                    width = 1;
                else
                    width = value;
            }
        }
        int Height
        {
            get
            {
                return height;
            }
            set     //  Высоту для разнообразия просто делаем ненулевой - вдруг мы строим подземелье и высота должна быть отрицательной)
            {
                if (value == 0)
                    height = 1;
                else
                    height = value;
            }
        }
        public Building(string adress, int length, int width, int height)
        {
            this.Adress = adress;
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            if (Height > 0)
                return $"Здание находится по адресу: {adress}, и имеет размеры {length}х{width}х{height}.";
            else
                return $"Подземное сооружение находится по адресу: {adress}, и имеет размеры {length}х{width}х{-height}.";       //  Высоту с минусом, чтобы не морочиться с модулем - раз отрицательная.
        }

    }
}
