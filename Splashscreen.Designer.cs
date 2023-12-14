namespace calorieCalulator
{
    partial class Splashscreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splashscreen));
            pictureBox1 = new PictureBox();
            progressBarBackground = new Panel();
            progressBarProgress = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            animationTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            progressBarBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(480, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 467);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // progressBarBackground
            // 
            progressBarBackground.BackColor = Color.SteelBlue;
            progressBarBackground.Controls.Add(progressBarProgress);
            progressBarBackground.Location = new Point(0, 454);
            progressBarBackground.Name = "progressBarBackground";
            progressBarBackground.Size = new Size(958, 33);
            progressBarBackground.TabIndex = 1;
            // 
            // progressBarProgress
            // 
            progressBarProgress.BackColor = Color.Navy;
            progressBarProgress.Location = new Point(0, 0);
            progressBarProgress.Name = "progressBarProgress";
            progressBarProgress.Size = new Size(251, 33);
            progressBarProgress.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 50F, FontStyle.Bold);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(76, 101);
            label1.Name = "label1";
            label1.Size = new Size(329, 108);
            label1.TabIndex = 2;
            label1.Text = "SuperFit";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 24F);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(34, 209);
            label2.Name = "label2";
            label2.Size = new Size(430, 52);
            label2.TabIndex = 6;
            label2.Text = "let's transform you to a hero";
            // 
            // Splashscreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(957, 486);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBarBackground);
            Controls.Add(pictureBox1);
            ForeColor = Color.SteelBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splashscreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += s;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            progressBarBackground.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel progressBarBackground;
        private Panel progressBarProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer animationTimer;
        private Label label1;
        private Label label2;
    }
}
