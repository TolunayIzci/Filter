using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.IO;


namespace _02_BitmapPlayground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // PopulateFilterPicker()
            Thread t = new Thread(PopulateFilterPicker);
            t.Start();
            t.Join();

        }

        public static Assembly[] GetSolutionAssemblies()
        {
            var assemblies = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.dll")
                                .Select(x => Assembly.Load(AssemblyName.GetAssemblyName(x)));
            return assemblies.ToArray();
        }


        private void PopulateFilterPicker()
        {


            GetSolutionAssemblies();
            //FilterPickerBox.Items.Add(new RedFilter());
            //FilterPickerBox.Items.Add(new GrayscaleFilter());
            //FilterPickerBox.Items.Add(new AverageFilter());
            var type = typeof(IFilter);
            var types = AppDomain.CurrentDomain.GetAssemblies();
            var a = types.SelectMany(s => s.GetTypes())
             .Where(p => type.IsAssignableFrom(p) && !p.IsInterface && !p.IsAbstract && p.IsClass);


            //var t=Assembly.GetEntryAssembly().GetReferencedAssemblies().Where(x => x.Name.StartsWith("RedFilter"));
            //var ab = t.Where(p => p.FullName /*typeof(IFilter).IsAssignableFrom(p)*/).Select(x => x.Name).ToList();
            


            //test
            //var t = Assembly
            //        .GetExecutingAssembly()
            //        .as                    .Select(x => Assembly.Load(x))
            //        .SelectMany(s => s.GetTypes());
            //var ab = t.Where(p => p.IsClass /*typeof(IFilter).IsAssignableFrom(p)*/).Select(x => x.Name).ToList();



            //var t = Assembly
            //        .GetExecutingAssembly()
            //        .GetReferencedAssemblies()
            //        .Select(x => Assembly.Load(x))
            //        .SelectMany(x => x.GetTypes()).Where(p => type.IsAssignableFrom(p)/* && !p.IsInterface && !p.IsAbstract && p.IsClass*/).ToList();
            List<object> filters = new List<object>();

            foreach (var item in a)
            {
                filters.Add(Activator.CreateInstance(item));
            }

            FilterPickerBox.Items.AddRange(filters.ToArray());
        }

        /// <summary>
        /// Applies a filter to an image.
        /// </summary>
        /// <param name="filter">The filter to apply. Must not be null.</param>
        /// <param name="image">The image to which the filter is applied.</param>
        /// <returns>A new image with the filter applied.</returns>
        private Image ApplyFilter(IFilter filter, Image image)
        {
            // Sanity check input
            if (filter == null)
                throw new ArgumentNullException(nameof(filter));

            if (image == null)
                throw new ArgumentNullException(nameof(image));

            // Create a new bitmap from the existing image
            Bitmap result = new Bitmap(image);

            // Copy the pixel colors of the existing bitmap to a new 2D - color array for further processing.
            Color[,] colors = new Color[result.Width, result.Height];
            for (int x = 0; x < result.Width; x++)
                for (int y = 0; y < result.Height; y++)
                    colors[x, y] = result.GetPixel(x, y);

            // Apply the user defined filter.
            var filteredImageData = filter.Apply(colors);

            // Copy the resulting array back to the bitmap
            for (int x = 0; x < result.Width; x++)
                for (int y = 0; y < result.Height; y++)
                    result.SetPixel(x, y, filteredImageData[x, y]);

            return result;
        }

        private void ApplyFilterButton_Click(object sender, EventArgs e)
        {
            if (FilterPickerBox.SelectedItem is IFilter selectedFilter)
                PictureBoxFiltered.Image = ApplyFilter(selectedFilter, PictureBoxOriginal.Image);
        }

        private void FilterPickerBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
