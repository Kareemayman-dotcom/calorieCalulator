namespace calorieCalulator
{
    partial class Weightscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weightscreen));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            weightText = new TextBox();
            label3 = new Label();
            label4 = new Label();
            heightText = new TextBox();
            calcbtn = new Panel();
            label5 = new Label();
            label6 = new Label();
            timeframetxt = new ComboBox();
            activityFactortxt = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            calcbtn.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(44, 22);
            label1.Name = "label1";
            label1.Size = new Size(329, 108);
            label1.TabIndex = 3;
            label1.Text = "SuperFit";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(541, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(529, 509);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(86, 115);
            label2.Name = "label2";
            label2.Size = new Size(254, 52);
            label2.TabIndex = 5;
            label2.Text = "get superhero fit";
            // 
            // weightText
            // 
            weightText.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            weightText.Location = new Point(226, 213);
            weightText.Name = "weightText";
            weightText.Size = new Size(100, 33);
            weightText.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(67, 215);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 7;
            label3.Text = "Enter your weight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(67, 275);
            label4.Name = "label4";
            label4.Size = new Size(145, 21);
            label4.TabIndex = 8;
            label4.Text = "your height in cm";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // heightText
            // 
            heightText.Font = new Font("Viner Hand ITC", 12F, FontStyle.Bold, GraphicsUnit.Point);
            heightText.Location = new Point(226, 273);
            heightText.Name = "heightText";
            heightText.Size = new Size(100, 33);
            heightText.TabIndex = 9;
            // 
            // calcbtn
            // 
            calcbtn.BackColor = Color.DarkBlue;
            calcbtn.Controls.Add(label5);
            calcbtn.Cursor = Cursors.Hand;
            calcbtn.Location = new Point(86, 476);
            calcbtn.Name = "calcbtn";
            calcbtn.Size = new Size(356, 45);
            calcbtn.TabIndex = 10;
            calcbtn.MouseClick += calcbtn_MouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Viner Hand ITC", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightCyan;
            label5.Location = new Point(66, -5);
            label5.Name = "label5";
            label5.Size = new Size(218, 65);
            label5.TabIndex = 4;
            label5.Text = "calculate";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.MouseClick += calcbtn_MouseClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(65, 401);
            label6.Name = "label6";
            label6.Size = new Size(211, 21);
            label6.TabIndex = 12;
            label6.Text = "superfit in how many days";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timeframetxt
            // 
            timeframetxt.DropDownStyle = ComboBoxStyle.DropDownList;
            timeframetxt.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeframetxt.FormattingEnabled = true;
            timeframetxt.Items.AddRange(new object[] { "90", "120", "150", "180", "210", "240", "270" });
            timeframetxt.Location = new Point(310, 399);
            timeframetxt.Name = "timeframetxt";
            timeframetxt.Size = new Size(84, 34);
            timeframetxt.TabIndex = 13;
            // 
            // activityFactortxt
            // 
            activityFactortxt.DropDownStyle = ComboBoxStyle.DropDownList;
            activityFactortxt.Font = new Font("Viner Hand ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            activityFactortxt.FormattingEnabled = true;
            activityFactortxt.Items.AddRange(new object[] { "Sedentary", "Lightly Active", "Moderately Active", "Very Active", "Extra Active" });
            activityFactortxt.Location = new Point(226, 331);
            activityFactortxt.Name = "activityFactortxt";
            activityFactortxt.Size = new Size(125, 34);
            activityFactortxt.TabIndex = 15;
            activityFactortxt.SelectedIndexChanged += activityFactortxt_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(67, 331);
            label7.Name = "label7";
            label7.Size = new Size(158, 21);
            label7.TabIndex = 14;
            label7.Text = "How Active are you";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Weightscreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1056, 556);
            Controls.Add(activityFactortxt);
            Controls.Add(label7);
            Controls.Add(timeframetxt);
            Controls.Add(label6);
            Controls.Add(calcbtn);
            Controls.Add(heightText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(weightText);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Weightscreen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Superfit";
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
        private Label label6;
        private ComboBox timeframetxt;
        private ComboBox activityFactortxt;
        private Label label7;
    }
}