using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_BitmapPlayground.Filters
{
    class GrayscaleFilter : IFilter
    {
        public Color[,] Apply(Color[,] input)
        {
            int width = input.GetLength(0);
            int height = input.GetLength(1);
            Color[,] result = new Color[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    var p = input[x, y];
                    int avg = (p.R + p.G + p.B) / 3;
                    result[x, y] = Color.FromArgb(p.A, avg, avg, avg);
                }
            }

            return result;
        }

        public string Name => "Filter Gray component";

        public override string ToString()
            => Name;
    }
}
