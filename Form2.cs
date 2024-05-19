using System;
using System.Windows.Forms;

namespace ImageFilter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if(Form1.mode == null) Text = "Original Image";
            else Text=Form1.mode.ToString() + " with option " + Form1.option.ToString()+" intensity "+Form1.intensity.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            IMGout.Image = Form1.IMGout;
        }
    }
}
