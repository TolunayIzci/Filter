using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BitmapPlayground
{
    /// <summary>
    /// Contains a filter.
    /// </summary>
    public interface IFilter
    {
        /// <summary>
        /// Applies the filter to the given image.
        /// </summary>
        /// <param name="input">The input pixel data. The coordinates are x and y of the pixel (from top left).</param>
        /// <returns>A new array of equal size that contains the filtered image.</returns>
        Color[,] Apply(Color[,] input);

        /// <summary>
        /// Provides a human readable name for the filter.
        /// </summary>
        string Name { get; }
    }
}
