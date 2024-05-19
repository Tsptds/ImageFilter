using System;
using System.Collections.Generic;
using System.Drawing;
using Accord.Imaging.Filters;


namespace ImageFilter
{
    public partial class Util
    {
        // Kernel dictionary
        public static Dictionary<string, double[,]> kernels = new Dictionary<string, double[,]>()
        {
                {"Box Blur 1", new[,]
                    {
                        {0.0,   0,    0,      0,      0,      0,      0},
                        { 0,    2025, 6120,   8145,   6120,   2025,   0},
                        { 0,    6120, 18496,  24616,  18496,  6120,   0},
                        { 0,    8145, 24616,  32761,  24616,  8145,   0},
                        { 0,    6120, 18496,  24616,  18496,  6120,   0},
                        { 0,    2025, 6120,   8145,   6120,   2025,   0},
                        { 0,    0,    0,      0,      0,      0,      0}
                    }

                },
                {"Gaussian Blur 1", new[,]
                    {
                        { 1.0,  2.0, 1.0 },
                        { 2.0,  4.0, 2.0 },
                        { 1.0,  2.0, 1.0 }
                    }
                },
                {"Gaussian Blur 2", new[,]
                    {
                        {37.00, 147.00, 256.00, 147.00, 37.00},
                        {147.00, 586.00, 952.00, 586.00, 147.00},
                        {256.00, 952.00, 1502.00, 952.00, 256.00},
                        {147.00, 586.00, 952.00, 586.00, 147.00},
                        {37.00, 147.00, 256.00, 147.00, 37.00}

                    }
                },
                {"Motion Blur 1", new[,]
                    {
                        { 1.0, 0.0, 0.0, 0.0, 0.0 },
                        { 0.0, 1.0, 0.0, 0.0, 0.0 },
                        { 0.0, 0.0, 1.0, 0.0, 0.0 },
                        { 0.0, 0.0, 0.0, 1.0, 0.0 },
                        { 0.0, 0.0, 0.0, 0.0, 1.0 }
                    }
                },
                {"Motion Blur 2", new[,]
                    {
                        { 0.0, 0.0, 0.0, 0.0, 1.0 },
                        { 0.0, 0.0, 0.0, 1.0, 0.0 },
                        { 0.0, 0.0, 1.0, 0.0, 0.0 },
                        { 0.0, 1.0, 0.0, 0.0, 0.0 },
                        { 1.0, 0.0, 0.0, 0.0, 0.0 }
                    }
                },
                {"Motion Blur 3", new[,]
                    {
                        { 0.0, 0.0, 0.0, 0.0, 0.0 },
                        { 0.0, 0.0, 0.0, 0.0, 0.0 },
                        { 1.0, 1.0, 1.0, 1.0, 1.0 },
                        { 0.0, 0.0, 0.0, 0.0, 0.0 },
                        { 0.0, 0.0, 0.0, 0.0, 0.0 }
                    }
                },
                {"Motion Blur 4", new[,]
                    {
                        { 0.0, 0.0, 1.0, 0.0, 0.0 },
                        { 0.0, 0.0, 1.0, 0.0, 0.0 },
                        { 0.0, 0.0, 1.0, 0.0, 0.0 },
                        { 0.0, 0.0, 1.0, 0.0, 0.0 },
                        { 0.0, 0.0, 1.0, 0.0, 0.0 }
                    }
                },
                {"Highlight Edges 1", new[,]
                    {
                        { -1.0, -1.0, -1.0 },
                        { -1.0,  8.0, -1.0 },
                        { -1.0, -1.0, -1.0 }
                    }
                },
                {"Highlight Edges 2", new[,]
                    {
                        { -2.0, -2.0, -2.0 },
                        { -2.0,  16.0, -2.0 },
                        { -2.0, -2.0, -2.0 }
                    }
                },
                {"Sharpen 1", new[,]
                    {
                        {  0.0, -1.0,  0.0 },
                        { -1.0,  5.0, -1.0 },
                        {  0.0, -1.0,  0.0 }
                    }
                },
                {"Sharpen 2", new[,]
                    {
                        {  0.0, -2.0,  0.0 },
                        { -2.0,  9.0, -2.0 },
                        {  0.0, -2.0,  0.0 }
                    }
                },
                {"Sharpen 3", new[,]
                    {
                        {  -1.0, -1.0,  -1.0 },
                        { -1.0,  9.0, -1.0 },
                        {  -1.0, -1.0,  -1.0 }
                    }
                },
                {"Sobel 1", new[,]      // Top
                    {
                        {  1.0,  2.0,  1.0 },
                        {  0.0,  0.0,  0.0 },
                        { -1.0, -2.0, -1.0 }
                    }
                },
                {"Sobel 2", new[,]      // Bottom
                    {
                        { -1.0, -2.0, -1.0 },
                        {  0.0,  0.0,  0.0 },
                        {  1.0,  2.0,  1.0 }
                    }
                },
                {"Sobel 3", new[,]      // Right
                    {
                        { -1.0, 0.0, 1.0 },
                        { -2.0, 0.0, 2.0 },
                        { -1.0, 0.0, 1.0 }
                    }
                },
                {"Sobel 4", new[,]      // Left
                    {
                        { 1.0, 0.0, -1.0 },
                        { 2.0, 0.0, -2.0 },
                        { 1.0, 0.0, -1.0 }
                    }
                },
                {"Emboss 1", new[,]     // NW to SE
                    {
                        { -2.0, -1.0, 0.0 },
                        { -1.0,  1.0, 1.0 },
                        {  0.0,  1.0, 2.0 }
                    }
                },
                {"Emboss 2", new[,]     // SE to NW
                    {
                        { 2.0,  1.0,  0.0 },
                        { 1.0,  1.0, -1.0 },
                        { 0.0, -1.0, -2.0 }
                    }
                },
                {"Emboss 3", new[,]     // NE to SW
                    {
                        {  0.0,  1.0, 2.0 },
                        { -1.0,  1.0, 1.0 },
                        { -2.0, -1.0, 0.0 }
                    }
                },
                {"Emboss 4", new[,]     // SW to NE
                    {
                        { 0.0, -1.0, -2.0 },
                        { 1.0,  1.0, -1.0 },
                        { 2.0,  1.0,  0.0 }
                    }
                }
        };

        // Functions
        public static int[,] ChooseKernel(string kernelName)
        {
            double[,] kernel = Util.kernels[kernelName];
            double sum = 0;
            int rows = kernel.GetLength(0);
            int cols = kernel.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // MessageBox.Show(Convert.ToString(kernel[i, j]));
                    result[i, j] = Convert.ToInt32(kernel[i, j]);
                    //result[i, j] = Convert.ToInt32(1000 * kernel[i, j]);
                    sum = result[i, j] + sum;
                }
            }


            if (sum == 0) Form1.kernelSum = 1;
            else Form1.kernelSum = sum;
            return result;
        }

        // Apply kernel multiple times
        public static Bitmap ApplyIntensity(int[,] kernel, double intensity)
        {
            Bitmap result = Form1.image;
            for (int i = 0; i < intensity; i++)
            {
                // Create the convolution filter
                Convolution filter = new Convolution(kernel);

                // Divide the image to its sum to normalize
                filter.Divisor = Convert.ToInt32(Form1.kernelSum);

                // Apply the filter
                result = filter.Apply(result);
            }
            return result;
        }

        // Change Saturation
        public static Bitmap Saturation(Bitmap image, double sFactor)
        {
            Bitmap output = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    double hue, saturation, value;
                    ColorToHSV(pixel, out hue, out saturation, out value);

                    // Modify the saturation
                    saturation += (sFactor / 10.0);
                    saturation = Math.Min(saturation, 1.0); // Limit values

                    Color newPixel = ColorFromHSV(hue, saturation, value);
                    output.SetPixel(x, y, newPixel);
                }
            }
            return output;
        }

        public static void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            double r = color.R / 255.0;
            double g = color.G / 255.0;
            double b = color.B / 255.0;

            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));
            double delta = max - min;

            hue = 0.0;
            if (delta != 0)
            {
                if (max == r)
                {
                    hue = (g - b) / delta;
                }
                else if (max == g)
                {
                    hue = 2.0 + (b - r) / delta;
                }
                else
                {
                    hue = 4.0 + (r - g) / delta;
                }
                hue *= 60.0;
                if (hue < 0)
                    hue += 360.0;
            }

            saturation = max == 0 ? 0 : (delta / max);
            value = max;
        }

        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            switch (hi)
            {
                case 0:
                    return Color.FromArgb(255, v, t, p);
                case 1:
                    return Color.FromArgb(255, q, v, p);
                case 2:
                    return Color.FromArgb(255, p, v, t);
                case 3:
                    return Color.FromArgb(255, p, q, v);
                case 4:
                    return Color.FromArgb(255, t, p, v);
                default:
                    return Color.FromArgb(255, v, p, q);
            }
        }

        // Change Gamma
        public static Bitmap Gamma(Bitmap image, double gFactor)
        {
            Bitmap output = new Bitmap(image.Width, image.Height);
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    int r = (int)(255 * Math.Pow(pixel.R / 255.0, 1 / (gFactor - 1)));
                    int g = (int)(255 * Math.Pow(pixel.G / 255.0, 1 / (gFactor - 1)));
                    int b = (int)(255 * Math.Pow(pixel.B / 255.0, 1 / (gFactor - 1)));

                    // Clamp values to the range [0, 255]
                    r = Math.Min(255, Math.Max(0, r));
                    g = Math.Min(255, Math.Max(0, g));
                    b = Math.Min(255, Math.Max(0, b));

                    output.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return output;
        }

        // Change Brightness
        public static Bitmap Brightness(Bitmap image, int bFactor)
        {
            Bitmap output = new Bitmap(image.Width, image.Height);
            int brightnessAdjustment = bFactor * 10;

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);

                    int r = pixel.R + brightnessAdjustment;
                    int g = pixel.G + brightnessAdjustment;
                    int b = pixel.B + brightnessAdjustment;

                    // Clamp values to the range [0, 255]
                    r = Math.Min(255, Math.Max(0, r));
                    g = Math.Min(255, Math.Max(0, g));
                    b = Math.Min(255, Math.Max(0, b));

                    output.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return output;
        }
    }
}
