namespace ImageFilter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnFileChoose = new System.Windows.Forms.Button();
            this.optionSlider = new System.Windows.Forms.TrackBar();
            this.sliderLabelOpt = new System.Windows.Forms.Label();
            this.lblNameOption = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTextFilter = new System.Windows.Forms.Label();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sliderLabelInt = new System.Windows.Forms.Label();
            this.sliderIntensity = new System.Windows.Forms.TrackBar();
            this.lblNameIntensity = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImgSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.optionSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderIntensity)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApplyFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplyFilter.Location = new System.Drawing.Point(230, 6);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(380, 50);
            this.btnApplyFilter.TabIndex = 0;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFileChoose
            // 
            this.btnFileChoose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFileChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileChoose.Location = new System.Drawing.Point(12, 6);
            this.btnFileChoose.Name = "btnFileChoose";
            this.btnFileChoose.Size = new System.Drawing.Size(145, 50);
            this.btnFileChoose.TabIndex = 1;
            this.btnFileChoose.Text = "Choose File";
            this.btnFileChoose.UseVisualStyleBackColor = true;
            this.btnFileChoose.Click += new System.EventHandler(this.button2_Click);
            // 
            // optionSlider
            // 
            this.optionSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionSlider.LargeChange = 1;
            this.optionSlider.Location = new System.Drawing.Point(114, 6);
            this.optionSlider.Maximum = 4;
            this.optionSlider.Minimum = 1;
            this.optionSlider.Name = "optionSlider";
            this.optionSlider.Size = new System.Drawing.Size(290, 45);
            this.optionSlider.TabIndex = 3;
            this.optionSlider.Value = 1;
            this.optionSlider.ValueChanged += new System.EventHandler(this.OptionSlider_ValueChanged);
            // 
            // sliderLabelOpt
            // 
            this.sliderLabelOpt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sliderLabelOpt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sliderLabelOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sliderLabelOpt.Location = new System.Drawing.Point(12, 54);
            this.sliderLabelOpt.Name = "sliderLabelOpt";
            this.sliderLabelOpt.Size = new System.Drawing.Size(392, 22);
            this.sliderLabelOpt.TabIndex = 4;
            this.sliderLabelOpt.Text = "1";
            this.sliderLabelOpt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNameOption
            // 
            this.lblNameOption.AutoSize = true;
            this.lblNameOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameOption.Location = new System.Drawing.Point(13, 6);
            this.lblNameOption.Name = "lblNameOption";
            this.lblNameOption.Size = new System.Drawing.Size(95, 20);
            this.lblNameOption.TabIndex = 5;
            this.lblNameOption.Text = "Filter Option";
            this.lblNameOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(884, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTextFilter);
            this.panel1.Controls.Add(this.cbx1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 119);
            this.panel1.TabIndex = 9;
            // 
            // lblTextFilter
            // 
            this.lblTextFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTextFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTextFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTextFilter.Location = new System.Drawing.Point(3, 0);
            this.lblTextFilter.Name = "lblTextFilter";
            this.lblTextFilter.Size = new System.Drawing.Size(183, 22);
            this.lblTextFilter.TabIndex = 6;
            this.lblTextFilter.Text = "Select Filter To Apply -->";
            this.lblTextFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbx1
            // 
            this.cbx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx1.DropDownHeight = 100;
            this.cbx1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx1.DropDownWidth = 100;
            this.cbx1.FormattingEnabled = true;
            this.cbx1.IntegralHeight = false;
            this.cbx1.Items.AddRange(new object[] {
            "Brightness",
            "Saturation",
            "Gamma",
            "Box Blur",
            "Sharpen",
            "Gaussian Blur",
            "Motion Blur",
            "Highlight Edges",
            "Sobel",
            "Emboss"});
            this.cbx1.Location = new System.Drawing.Point(230, 4);
            this.cbx1.Name = "cbx1";
            this.cbx1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbx1.Size = new System.Drawing.Size(641, 21);
            this.cbx1.TabIndex = 1;
            this.cbx1.SelectedIndexChanged += new System.EventHandler(this.cbx1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sliderLabelInt);
            this.panel3.Controls.Add(this.sliderIntensity);
            this.panel3.Controls.Add(this.lblNameIntensity);
            this.panel3.Controls.Add(this.optionSlider);
            this.panel3.Controls.Add(this.lblNameOption);
            this.panel3.Controls.Add(this.sliderLabelOpt);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(882, 92);
            this.panel3.TabIndex = 11;
            // 
            // sliderLabelInt
            // 
            this.sliderLabelInt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderLabelInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sliderLabelInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sliderLabelInt.Location = new System.Drawing.Point(467, 54);
            this.sliderLabelInt.Name = "sliderLabelInt";
            this.sliderLabelInt.Size = new System.Drawing.Size(404, 22);
            this.sliderLabelInt.TabIndex = 8;
            this.sliderLabelInt.Text = "1";
            this.sliderLabelInt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sliderIntensity
            // 
            this.sliderIntensity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderIntensity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderIntensity.LargeChange = 1;
            this.sliderIntensity.Location = new System.Drawing.Point(581, 6);
            this.sliderIntensity.Maximum = 5;
            this.sliderIntensity.Minimum = 1;
            this.sliderIntensity.Name = "sliderIntensity";
            this.sliderIntensity.Size = new System.Drawing.Size(290, 45);
            this.sliderIntensity.TabIndex = 7;
            this.sliderIntensity.Value = 1;
            this.sliderIntensity.ValueChanged += new System.EventHandler(this.sliderIntensity_ValueChanged);
            // 
            // lblNameIntensity
            // 
            this.lblNameIntensity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNameIntensity.AutoSize = true;
            this.lblNameIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNameIntensity.Location = new System.Drawing.Point(467, 6);
            this.lblNameIntensity.Name = "lblNameIntensity";
            this.lblNameIntensity.Size = new System.Drawing.Size(108, 20);
            this.lblNameIntensity.TabIndex = 6;
            this.lblNameIntensity.Text = "Filter Intensity";
            this.lblNameIntensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImgSave);
            this.panel2.Controls.Add(this.btnApplyFilter);
            this.panel2.Controls.Add(this.btnFileChoose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 61);
            this.panel2.TabIndex = 10;
            // 
            // btnImgSave
            // 
            this.btnImgSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImgSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImgSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImgSave.Location = new System.Drawing.Point(727, 6);
            this.btnImgSave.Name = "btnImgSave";
            this.btnImgSave.Size = new System.Drawing.Size(145, 50);
            this.btnImgSave.TabIndex = 2;
            this.btnImgSave.Text = "Save Image";
            this.btnImgSave.UseVisualStyleBackColor = true;
            this.btnImgSave.Click += new System.EventHandler(this.btnImgSave_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(884, 351);
            this.panel4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 531);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(900, 540);
            this.Name = "Form1";
            this.Text = "ImageFilter";
            ((System.ComponentModel.ISupportInitialize)(this.optionSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderIntensity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnFileChoose;
        private System.Windows.Forms.TrackBar optionSlider;
        private System.Windows.Forms.Label sliderLabelOpt;
        private System.Windows.Forms.Label lblNameOption;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnImgSave;
        private System.Windows.Forms.Label lblTextFilter;
        private System.Windows.Forms.TrackBar sliderIntensity;
        private System.Windows.Forms.Label lblNameIntensity;
        private System.Windows.Forms.Label sliderLabelInt;
    }
}

