namespace hw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Rectangle labelArea = label1.Bounds;
            this.Text = "";
            this.Text += labelArea;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Out of zone";
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "In zone";
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            int borderWidth = 1;
            this.Text = "";
            this.Text += "X: " + e.X + " Y: " + e.Y;

            if (e.X == borderWidth || e.Y == borderWidth || e.X == borderWidth && e.Y == borderWidth)
            {
                label1.Text = "Nearby the border";
            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Rectangle labelArea = label1.Bounds;
            this.Text = "";
            this.Text += labelArea;
        }
    }
}