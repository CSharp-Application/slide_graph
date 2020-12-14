
using System.Drawing;
using System.Windows.Forms;

namespace スライドグラフ
{
    public partial class Form1 : Form
    {
        int[] data = new int[615];

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics g = Graphics.FromImage(bitmap);
            for (int i = data.Length - 1; i > 0; i--)
            {
                data[i] = data[i - 1];
            }
            data[0] = hantai(trackBar1.Value,pictureBox1.Height);
            for (int i = 0; i < data.Length - 1; i++)
            {
                g.DrawLine(Pens.Black, i, data[i], i + 1, data[i + 1]);
            }
            pictureBox1.Image = bitmap;
        }

        public static int hantai(int i,int made)
        {
            return made - i;
        }
    }
}
