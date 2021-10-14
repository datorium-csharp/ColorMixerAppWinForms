namespace ColorMixerAppWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "My color mixer";
        }

        private void numericUpDownRed_ValueChanged(object sender, EventArgs e)
        {
            int red = (int)numericUpDownRed.Value;
            int green = (int)numericUpDownGreen.Value;
            int blue = (int)numericUpDownBlue.Value;

            pictureBoxRed.BackColor = Color.FromArgb(red, 0, 0);
            this.BackColor = Color.FromArgb(red, green, blue);

            trackBarRed.Value = red;
        }

        private void numericUpDownGreen_ValueChanged(object sender, EventArgs e)
        {
            int red = (int)numericUpDownRed.Value;
            int green = (int)numericUpDownGreen.Value;
            int blue = (int)numericUpDownBlue.Value;

            pictureBoxGreen.BackColor = Color.FromArgb(0, green, 0);
            this.BackColor = Color.FromArgb(red, green, blue);

            trackBarGreen.Value = green;
        }

        private void numericUpDownBlue_ValueChanged(object sender, EventArgs e)
        {
            int red = (int)numericUpDownRed.Value;
            int green = (int)numericUpDownGreen.Value;
            int blue = (int)numericUpDownBlue.Value;

            pictureBoxBlue.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);

            trackBarBlue.Value = blue;
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            numericUpDownRed.Value = trackBarRed.Value;
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            numericUpDownGreen.Value = trackBarGreen.Value;
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            numericUpDownBlue.Value = trackBarBlue.Value;
        }
    }
}