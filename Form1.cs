using System;
using System.Drawing;
using System.Media;
using System.Reflection.Emit;
using System.Windows.Forms;
namespace ImageFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ImagePath;
        static OpenFileDialog openFileDialog1;
        static SaveFileDialog saveFileDialog1;
        public static Bitmap image;
        public static double kernelSum;
        public static double intensity = 1;
        public static double option = 1;
        public static string mode;
        public static Image IMGout;

        int[,] kernel;

        

        // Event calls
        private void button1_Click(object sender, EventArgs e)
        {
            if (image == null || cbx1.Text == "")
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("No image / filter selected");
                return;
            }
            mode=cbx1.Text;

            if (cbx1.Text == "Saturation")
            {
                IMGout = Util.Saturation(image, intensity);
                if (IMGout == null) return;
                goto DisplayImage;
            }
            else if (cbx1.Text == "Brightness")
            {
                IMGout = Util.Brightness(image, (int)intensity);
                if (IMGout == null) return;
                goto DisplayImage;
            }
            else if (cbx1.Text == "Gamma")
            {
                IMGout = Util.Gamma(image, intensity);
                if (IMGout == null) return;
                goto DisplayImage;
            }
            else if (cbx1.Text == "Convert to Grayscale")
            {
                IMGout = Util.ConvertGrayScale(image);
                if (IMGout == null) return;
                goto DisplayImage;
            }

            try
            {
                // Pick a convolution kernel
                kernel = Util.ChooseKernel(mode + " " + optionSlider.Value);

                // Apply intensity level
                //MessageBox.Show("applying intensity");
                IMGout = Util.ApplyIntensity(kernel, intensity);
            }
            catch{
                SystemSounds.Exclamation.Play();
                MessageBox.Show("There is no kernel defined for this option, try a lower one.");
                return;
            }

            DisplayImage:
            // Display IMGout on new form
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImagePath = openFileDialog1.FileName;
                image = Util.LoadBitmapNolock(ImagePath);
                pictureBox1.Image = image;
            }
        }

        private void btnImgSave_Click(object sender, EventArgs e)
        {
            // Save the result
            if(IMGout== null)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("No processed image");
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImagePath = saveFileDialog1.FileName;
                IMGout.Save(ImagePath);
                MessageBox.Show("Image Saved at "+ImagePath);
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (image == null) return;
            mode = null;
            Form2 f2 = new Form2();
            IMGout = image;
            f2.Show();
        }

        private void sliderIntensity_ValueChanged(object sender, EventArgs e)
        {
            intensity = sliderIntensity.Value;
            sliderLabelInt.Text = intensity.ToString();
        }

        private void OptionSlider_ValueChanged(object sender, EventArgs e)
        {
            option = optionSlider.Value;
            sliderLabelOpt.Text = option.ToString();
        }

        private void cbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbx1.Text == "Saturation" || cbx1.Text == "Brightness" || cbx1.Text == "Gamma")
            {
                optionSlider.Enabled = false;
                sliderIntensity.Enabled = true;
                sliderIntensity.Minimum = -5;
                sliderIntensity.Maximum = 5;
            }
            else if (cbx1.Text == "Box Blur" || cbx1.Text == "Gaussian Blur" || cbx1.Text == "Motion Blur")
            {
                sliderIntensity.Maximum = 5;
                optionSlider.Enabled = true;
                sliderIntensity.Enabled = true;
                sliderIntensity.Minimum = 1;
            }
            else if (cbx1.Text == "Sharpen")
            {
                sliderIntensity.Maximum = 2;
                optionSlider.Enabled = true;
                sliderIntensity.Enabled = true;
                sliderIntensity.Minimum = 1;
            }
            else if (cbx1.Text == "Convert to Grayscale")
            {
                optionSlider.Enabled = false;
                sliderIntensity.Enabled = false;
            }
            else if(cbx1.Text == "Highlight Edges" || cbx1.Text == "Sobel" || cbx1.Text == "Emboss")
            {
                sliderIntensity.Minimum = 1;
                sliderIntensity.Maximum = 2;
                optionSlider.Enabled = true;
                sliderIntensity.Enabled = true;
            }
            else
            {
                optionSlider.Enabled = false;
                sliderIntensity.Enabled = false;
                sliderIntensity.Minimum = 1;
                sliderIntensity.Maximum = 1;
            }
            intensity = sliderIntensity.Value;
            sliderLabelInt.Text = intensity.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = ImagePath;
            openFileDialog1.Title = "Save Edited Image";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|jpeg|*.jpg|jpeg|*.jpeg|bitmap|*.bmp|png|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = ImagePath;
            saveFileDialog1.Title = "Save Edited Image";
            saveFileDialog1.Filter = "jpg|*.jpg|Bitmap|*.bmp|png|*.png";
            saveFileDialog1.RestoreDirectory = true;
        }
    }
}
