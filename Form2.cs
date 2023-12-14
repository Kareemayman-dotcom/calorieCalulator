using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calorieCalulator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw rounded corners for text fields
            DrawRoundedCorners(weightText,10);
            DrawRoundedCorners(heightText,10);
            DrawRoundedCorners(calcbtn,20);
            
        }

        private void DrawRoundedCorners(Control control ,int radius)
        {
             // Adjust the radius based on your preference

            GraphicsPath path = new GraphicsPath();
            path.AddArc(control.ClientRectangle.X, control.ClientRectangle.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(control.ClientRectangle.Right - radius * 2, control.ClientRectangle.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(control.ClientRectangle.Right - radius * 2, control.ClientRectangle.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(control.ClientRectangle.X, control.ClientRectangle.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }
    }
}
