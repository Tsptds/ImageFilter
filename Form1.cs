using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
namespace ImageFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ImageFile;
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
                IMGout = Util.Saturation(image, sliderIntensity.Value);
                if (IMGout == null) return;
                goto DisplayImage;
            }
            else if (cbx1.Text == "Brightness")
            {
                IMGout = Util.Brightness(image, sliderIntensity.Value);
                if (IMGout == null) return;
                goto DisplayImage;
            }
            else if (cbx1.Text == "Gamma")
            {
                IMGout = Util.Gamma(image, sliderIntensity.Value);
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            ImageFile = openFileDialog1.FileName;
            image = new Bitmap(ImageFile);
            pictureBox1.Image = image;
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
            IMGout.Save("out.jpg");
            MessageBox.Show("Image Saved as \"out.jpg\"");
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
            if(cbx1.Text == "Saturation" || cbx1.Text == "Brightness" || cbx1.Text == "Gamma"){
                optionSlider.Enabled = false;
            }
            else optionSlider.Enabled = true;
        }
    }
}
