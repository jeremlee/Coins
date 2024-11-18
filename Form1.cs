using ImageProcess2;

namespace Coins_Activity
{
    public partial class Form1 : Form
    {
        Bitmap? loaded, processed;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (loaded == null) return;
            processed = new Bitmap(loaded.Width, loaded.Height);
            BitmapFilter.Binary(loaded, processed, 200);
            Coins.CountCoins(processed, ref label2, ref label5);
            pictureBox2.Image = processed;
        }
    }
}
