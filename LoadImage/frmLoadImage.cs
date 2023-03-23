using System.Windows.Forms;

namespace LoadImage
{
    public partial class frmLoadImage : Form
    {
        public frmLoadImage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                string[] imageName = ofd.FileName.Split('\\');
                textBox2.Text = imageName[imageName.Length - 1];
            }
        }
    }

}