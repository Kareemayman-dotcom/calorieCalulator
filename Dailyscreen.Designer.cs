namespace calorieCalulator
{
    partial class Dailyscreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dailyscreen));
            pictureBox1 = new PictureBox();
            sideBar = new FlowLayoutPanel();
            menuContainer = new Panel();
            menuBtn = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            ingrList = new ListBox();
            amounttxt = new TextBox();
            unittxt = new ComboBox();
            ingrtxt = new TextBox();
            label5 = new Label();
            day_caloriestxt = new Label();
            label7 = new Label();
            day_protientxt = new Label();
            label9 = new Label();
            day_carbstxt = new Label();
            addbtn = new Panel();
            addlabel = new Label();
            removelabel = new Label();
            removebtn = new Panel();
            label13 = new Label();
            targetCaloriestxt = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            sideBar.SuspendLayout();
            menuContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuBtn).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            addbtn.SuspendLayout();
            removebtn.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(597, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(460, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.Navy;
            sideBar.Controls.Add(menuContainer);
            sideBar.Controls.Add(panel1);
            sideBar.Controls.Add(panel2);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.MaximumSize = new Size(205, 595);
            sideBar.MinimumSize = new Size(78, 595);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(78, 595);
            sideBar.TabIndex = 6;
            sideBar.Paint += flowLayoutPanel1_Paint;
            // 
            // menuContainer
            // 
            menuContainer.AutoSize = true;
            menuContainer.BackColor = Color.Navy;
            menuContainer.Controls.Add(menuBtn);
            menuContainer.Controls.Add(label1);
            menuContainer.Location = new Point(3, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(192, 67);
            menuContainer.TabIndex = 0;
            // 
            // menuBtn
            // 
            menuBtn.Cursor = Cursors.Hand;
            menuBtn.Image = (Image)resources.GetObject("menuBtn.Image");
            menuBtn.Location = new Point(3, 0);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(69, 64);
            menuBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            menuBtn.TabIndex = 6;
            menuBtn.TabStop = false;
            menuBtn.MouseClick += menuButton_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Viner Hand ITC", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightCyan;
            label1.Location = new Point(93, 6);
            label1.Name = "label1";
            label1.Size = new Size(96, 44);
            label1.TabIndex = 7;
            label1.Text = "menu";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 88);
            panel1.Margin = new Padding(3, 15, 3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 63);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(9, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Viner Hand ITC", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightCyan;
            label2.Location = new Point(93, 16);
            label2.Name = "label2";
            label2.Size = new Size(87, 44);
            label2.TabIndex = 7;
            label2.Text = "home";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 169);
            panel2.Margin = new Padding(3, 15, 3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 58);
            panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.AliceBlue;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(59, 55);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.MouseClick += scaleClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Viner Hand ITC", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightCyan;
            label3.Location = new Point(93, 11);
            label3.Name = "label3";
            label3.Size = new Size(111, 44);
            label3.TabIndex = 7;
            label3.Text = "weight";
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += timer1_Tick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Viner Hand ITC", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightCyan;
            label4.Location = new Point(96, -4);
            label4.Name = "label4";
            label4.Size = new Size(495, 108);
            label4.TabIndex = 7;
            label4.Text = "Daily Progress";
            // 
            // ingrList
            // 
            ingrList.Font = new Font("Viner Hand ITC", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ingrList.FormattingEnabled = true;
            ingrList.ItemHeight = 39;
            ingrList.Location = new Point(174, 218);
            ingrList.Name = "ingrList";
            ingrList.Size = new Size(289, 121);
            ingrList.TabIndex = 8;
            // 
            // amounttxt
            // 
            amounttxt.Font = new Font("Viner Hand ITC", 16F, FontStyle.Regular, GraphicsUnit.Point);
            amounttxt.Location = new Point(164, 139);
            amounttxt.Name = "amounttxt";
            amounttxt.PlaceholderText = "amount";
            amounttxt.Size = new Size(88, 42);
            amounttxt.TabIndex = 9;
            amounttxt.TextChanged += textBox1_TextChanged;
            // 
            // unittxt
            // 
            unittxt.AccessibleName = "";
            unittxt.DropDownStyle = ComboBoxStyle.DropDownList;
            unittxt.Font = new Font("Viner Hand ITC", 16F, FontStyle.Regular, GraphicsUnit.Point);
            unittxt.FormattingEnabled = true;
            unittxt.Items.AddRange(new object[] { "g", "cup", "spoon", "table spoon" });
            unittxt.Location = new Point(258, 139);
            unittxt.Name = "unittxt";
            unittxt.Size = new Size(126, 42);
            unittxt.TabIndex = 10;
            // 
            // ingrtxt
            // 
            ingrtxt.Font = new Font("Viner Hand ITC", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ingrtxt.Location = new Point(390, 139);
            ingrtxt.Name = "ingrtxt";
            ingrtxt.PlaceholderText = "ingredient";
            ingrtxt.Size = new Size(163, 42);
            ingrtxt.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Viner Hand ITC", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightCyan;
            label5.Location = new Point(113, 410);
            label5.Name = "label5";
            label5.Size = new Size(139, 52);
            label5.TabIndex = 12;
            label5.Text = "calories";
            // 
            // day_caloriestxt
            // 
            day_caloriestxt.AutoSize = true;
            day_caloriestxt.BackColor = Color.Transparent;
            day_caloriestxt.Font = new Font("Viner Hand ITC", 50F, FontStyle.Bold, GraphicsUnit.Point);
            day_caloriestxt.ForeColor = Color.DarkRed;
            day_caloriestxt.Location = new Point(101, 439);
            day_caloriestxt.Name = "day_caloriestxt";
            day_caloriestxt.Size = new Size(75, 108);
            day_caloriestxt.TabIndex = 13;
            day_caloriestxt.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Viner Hand ITC", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.LightCyan;
            label7.Location = new Point(275, 410);
            label7.Name = "label7";
            label7.Size = new Size(133, 52);
            label7.TabIndex = 14;
            label7.Text = "protien";
            // 
            // day_protientxt
            // 
            day_protientxt.AutoSize = true;
            day_protientxt.BackColor = Color.Transparent;
            day_protientxt.Font = new Font("Viner Hand ITC", 50F, FontStyle.Bold, GraphicsUnit.Point);
            day_protientxt.ForeColor = Color.DarkRed;
            day_protientxt.Location = new Point(258, 439);
            day_protientxt.Name = "day_protientxt";
            day_protientxt.Size = new Size(75, 108);
            day_protientxt.TabIndex = 15;
            day_protientxt.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Viner Hand ITC", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.LightCyan;
            label9.Location = new Point(441, 410);
            label9.Name = "label9";
            label9.Size = new Size(100, 52);
            label9.TabIndex = 16;
            label9.Text = "carbs";
            // 
            // day_carbstxt
            // 
            day_carbstxt.AutoSize = true;
            day_carbstxt.BackColor = Color.Transparent;
            day_carbstxt.Font = new Font("Viner Hand ITC", 50F, FontStyle.Bold, GraphicsUnit.Point);
            day_carbstxt.ForeColor = Color.DarkRed;
            day_carbstxt.Location = new Point(414, 439);
            day_carbstxt.Name = "day_carbstxt";
            day_carbstxt.Size = new Size(75, 108);
            day_carbstxt.TabIndex = 17;
            day_carbstxt.Text = "0";
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.DarkBlue;
            addbtn.Controls.Add(addlabel);
            addbtn.Cursor = Cursors.Hand;
            addbtn.Location = new Point(559, 139);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 45);
            addbtn.TabIndex = 18;
            addbtn.MouseClick += Addingrbtn_MouseClick;
            // 
            // addlabel
            // 
            addlabel.AutoSize = true;
            addlabel.BackColor = Color.Transparent;
            addlabel.Font = new Font("Viner Hand ITC", 16F, FontStyle.Bold, GraphicsUnit.Point);
            addlabel.ForeColor = Color.White;
            addlabel.Location = new Point(14, 7);
            addlabel.Name = "addlabel";
            addlabel.Size = new Size(69, 36);
            addlabel.TabIndex = 16;
            addlabel.Text = "ADD";
            addlabel.MouseClick += Addingrbtn_MouseClick;
            // 
            // removelabel
            // 
            removelabel.AutoSize = true;
            removelabel.BackColor = Color.Transparent;
            removelabel.Dock = DockStyle.Fill;
            removelabel.Font = new Font("Viner Hand ITC", 16F, FontStyle.Bold, GraphicsUnit.Point);
            removelabel.ForeColor = Color.White;
            removelabel.Location = new Point(0, 0);
            removelabel.Margin = new Padding(0);
            removelabel.Name = "removelabel";
            removelabel.Size = new Size(90, 36);
            removelabel.TabIndex = 16;
            removelabel.Text = "remove";
            removelabel.MouseClick += RemoveBtn_Click;
            // 
            // removebtn
            // 
            removebtn.BackColor = Color.Crimson;
            removebtn.Controls.Add(removelabel);
            removebtn.Cursor = Cursors.Hand;
            removebtn.Location = new Point(498, 246);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(94, 45);
            removebtn.TabIndex = 19;
            removebtn.MouseClick += RemoveBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Viner Hand ITC", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.LightCyan;
            label13.Location = new Point(624, 31);
            label13.Name = "label13";
            label13.Size = new Size(267, 52);
            label13.TabIndex = 20;
            label13.Text = "Target calories :";
            // 
            // targetCaloriestxt
            // 
            targetCaloriestxt.AutoSize = true;
            targetCaloriestxt.BackColor = Color.Transparent;
            targetCaloriestxt.Font = new Font("Viner Hand ITC", 50F, FontStyle.Bold, GraphicsUnit.Point);
            targetCaloriestxt.ForeColor = Color.DarkRed;
            targetCaloriestxt.Location = new Point(883, 9);
            targetCaloriestxt.Name = "targetCaloriestxt";
            targetCaloriestxt.Size = new Size(183, 108);
            targetCaloriestxt.TabIndex = 21;
            targetCaloriestxt.Text = "2500";
            // 
            // Dailyscreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(1056, 556);
            Controls.Add(targetCaloriestxt);
            Controls.Add(label13);
            Controls.Add(removebtn);
            Controls.Add(sideBar);
            Controls.Add(addbtn);
            Controls.Add(label9);
            Controls.Add(day_carbstxt);
            Controls.Add(label7);
            Controls.Add(day_protientxt);
            Controls.Add(label5);
            Controls.Add(day_caloriestxt);
            Controls.Add(ingrtxt);
            Controls.Add(unittxt);
            Controls.Add(amounttxt);
            Controls.Add(ingrList);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dailyscreen";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Superfit";
            Load += Dailyscreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            sideBar.ResumeLayout(false);
            sideBar.PerformLayout();
            menuContainer.ResumeLayout(false);
            menuContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuBtn).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            addbtn.ResumeLayout(false);
            addbtn.PerformLayout();
            removebtn.ResumeLayout(false);
            removebtn.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Addbtn_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel sideBar;
        private Panel menuContainer;
        private PictureBox menuBtn; // Changed from menuButton to menuBtn
        private Label label1;
        private System.Windows.Forms.Timer sideBarTimer;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private ListBox ingrList;
        private TextBox amounttxt;
        private ComboBox unittxt;
        private TextBox ingrtxt;
        private Label label5;
        private Label day_caloriestxt;
        private Label label7;
        private Label day_protientxt;
        private Label label9;
        private Label day_carbstxt;
        private Panel addbtn;
        private Label addlabel;
        private Label removelabel;
        private Panel removebtn;
        private Label label13;
        private Label targetCaloriestxt;
    }
}
