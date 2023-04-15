﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class MainFormViewModel
    {

        public string Width { get; set; }
        public string Length { get; set; }
        private int GetLength()
        {
            if (int.TryParse(Length, out int length) == false)
            {
                throw new ArgumentException("Длина должна быть числом.", nameof(Length));
            }
            if (length <= 0)
            {
                throw new ArgumentException("Длина должна быть положительным числом.", nameof(Length));
            }

            return 0;
        }

        private int GetWidth()
        {
            if (int.TryParse(Width, out int width) == false)
            {
                throw new ArgumentException("Высота должна быть числом.", nameof(Width));
            }
            if (width <= 0)
            {
                throw new ArgumentException("Высота должна быть положительным числом.", nameof(Width));
            }

            return width;
        }

        public int GetArea()
        {
            int width = GetWidth();
            int length = GetLength();

            return width * length;
        }

        public int GetPerimeter()
        {
            int width = GetWidth();
            int length = GetLength();

            return 2 * width + 2*length;
        }
    }
}
