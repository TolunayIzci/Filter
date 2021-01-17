using System.Drawing;

namespace _02_BitmapPlayground.Filters
{
    class AverageFilter : IFilter
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
                    if ((x == 0) || (y == height - 1) || (x == width - 1) || (y == 0))
                    {
                        result[x, y] = input[x, y];
                    }
                    else
                    {
                        var p = input[x, y];
                        var testR = (input[x - 1, y].R + input[x, y - 1].R + input[x, y + 1].R + input[x + 1, y].R) / 4;
                        var testG = (input[x - 1, y].G + input[x, y - 1].G + input[x, y + 1].G + input[x + 1, y].G) / 4;
                        var testB = (input[x - 1, y].B + input[x, y - 1].B + input[x, y + 1].B + input[x + 1, y].B) / 4;

                        result[x, y] = Color.FromArgb(p.A, testR, testG, testB);
                    }
                }
            }

            return result;
        }

        public string Name => "Moving Avarage component";

        public override string ToString() => Name;
    }
}