namespace calorieCalulator
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            weightText = new TextBox();
            label3 = new Label();
            label4 = new Label();
            heightText = new TextBox();
            calcbtn = new Panel();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            calcbtn.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 50F, FontStyle.Bold);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(40, 31);
            label1.Name = "label1";
            label1.Size = new Size(329, 108);
            label1.TabIndex = 3;
            label1.Text = "SuperFit";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(412, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 404);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 24F);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(82, 124);
            label2.Name = "label2";
            label2.Size = new Size(254, 52);
            label2.TabIndex = 5;
            label2.Text = "get superhero fit";
            // 
            // weightText
            // 
            weightText.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold);
            weightText.Location = new Point(199, 213);
            weightText.Name = "weightText";
            weightText.Size = new Size(100, 33);
            weightText.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(40, 215);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 7;
            label3.Text = "Enter your weight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(40, 275);
            label4.Name = "label4";
            label4.Size = new Size(145, 21);
            label4.TabIndex = 8;
            label4.Text = "your height in cm";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // heightText
            // 
            heightText.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold);
            heightText.Location = new Point(199, 273);
            heightText.Name = "heightText";
            heightText.Size = new Size(100, 33);
            heightText.TabIndex = 9;
            // 
            // calcbtn
            // 
            calcbtn.BackColor = Color.DarkBlue;
            calcbtn.Controls.Add(label5);
            calcbtn.Location = new Point(40, 375);
            calcbtn.Name = "calcbtn";
            calcbtn.Size = new Size(356, 45);
            calcbtn.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Viner Hand ITC", 30F, FontStyle.Bold);
            label5.ForeColor = Color.LightCyan;
            label5.Location = new Point(66, -5);
            label5.Name = "label5";
            label5.Size = new Size(218, 65);
            label5.TabIndex = 4;
            label5.Text = "calculate";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(853, 474);
            Controls.Add(calcbtn);
            Controls.Add(heightText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(weightText);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            calcbtn.ResumeLayout(false);
            calcbtn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox weightText;
        private Label label3;
        private Label label4;
        private TextBox heightText;
        private Panel calcbtn;
        private Label label5;
    }
}