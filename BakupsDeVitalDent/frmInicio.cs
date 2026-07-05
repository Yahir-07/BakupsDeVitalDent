namespace BakupsDeVitalDent
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneral_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Location = new Point(btn.Location.X + 3, btn.Location.Y + 3);
        }

        private void btnGeneral_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Location = new Point(btn.Location.X - 3, btn.Location.Y - 3);
        }
    }
}
