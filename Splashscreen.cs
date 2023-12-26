using System.Drawing.Drawing2D;
using System.Media;

namespace calorieCalulator
{
    public partial class Splashscreen : Form
    {
        private int progressBarWidth;
        private SoundPlayer soundPlayer;

        public Splashscreen()
        {
            InitializeComponent();
            // Initialize and start the timer

            PlayBackgroundMusic();
            animationTimer.Interval = 50; // Set the interval according to your preference
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a rounded rectangle for the form
            GraphicsPath roundedRect = GetRoundedRect(ClientRectangle, 20);
            this.Region = new Region(roundedRect);

            // Draw other elements as needed
            // e.g., draw your progress bar and other controls
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath roundedRect = new GraphicsPath();

            roundedRect.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            roundedRect.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            roundedRect.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            roundedRect.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            roundedRect.CloseFigure();

            return roundedRect;
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            // Update the progress bar width
            progressBarWidth += 10; // Adjust the value based on your desired animation speed

            // Check if the progress bar is at its maximum width
            if (progressBarWidth >= progressBarBackground.Width)
            {
                        animationTimer.Stop();

                if (GlobalVariables.person == null)
                {
                    Weightscreen wieghtScreen = new Weightscreen();
                    this.Hide();
                    wieghtScreen.ShowDialog();
                }
                else {
                    Dailyscreen dailyscreen = new Dailyscreen();
                    this.Hide();
                    dailyscreen.ShowDialog();
                }
            }

            // Update the width of the progress bar
            progressBarProgress.Width = progressBarWidth;
        }
        private void PlayBackgroundMusic()
        {

            // Convert the byte array to a MemoryStream
            try
            {
                soundPlayer = new SoundPlayer();
                soundPlayer.SoundLocation = Path.Combine(Application.StartupPath, "Resources", "superherosound.wav");

                // Load the sound file
                soundPlayer.Load();

                // Play the music in a loop
                soundPlayer.PlayLooping();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
