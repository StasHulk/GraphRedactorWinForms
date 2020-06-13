using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Графический_Редактор
{
    public partial class Form1 : Form
    {
        public PictureBox pictureBox;
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        ColorDialog colorDialog;
        public Bitmap originalImage;
        public bool isDrawing;
        bool isMouseDown;
        Color drawColor;
        public Form1()
        {
            InitializeComponent();
            pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            colorDialog = new ColorDialog();
            isDrawing = false;
            isMouseDown = false;
            drawColor = Color.White;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(pictureBox);
        }



        public void setImage()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
                pictureBox.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
                pictureBox.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
                pictureBox.MouseUp += new MouseEventHandler(pictureBox_MouseUp);
                originalImage = new Bitmap(openFileDialog.FileName);
            }
            flowLayoutPanel1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.Items.AddRange(new string[] { "R", "G", "B" });
            comboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setImage();
        }

        public Bitmap ToGrayScale(Bitmap Bmp)
        {
            int rgb;
            Color c;
            for (int y = 0; y < Bmp.Height; y++)
                for (int x = 0; x < Bmp.Width; x++)
                {
                    c = Bmp.GetPixel(x, y);
                    rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                    Bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                }
            return Bmp;
        }

        public Bitmap ToSepia(Bitmap Bmp)
        {
            int tr, tg, tb;
            Color pixelColor;
            for (int x = 0; x < Bmp.Width; x++)
            {
                for (int y = 0; y < Bmp.Height; y++)
                {
                    pixelColor = Bmp.GetPixel(x, y);
                    tr = (int) (0.393 * pixelColor.R + 0.769 * pixelColor.G + 0.189 * pixelColor.B);
                    tg = (int) (0.349 * pixelColor.R + 0.686 * pixelColor.G + 0.168 * pixelColor.B);
                    tb = (int) (0.272 * pixelColor.R + 0.534 * pixelColor.G + 0.131 * pixelColor.B);
                    if(tr > 255) tr = 255;
                    if(tg > 255) tg = 255;
                    if(tb > 255) tb = 255;
                    Bmp.SetPixel(x, y, Color.FromArgb(tr, tg, tb));
                }
            }
            return Bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pictureBox.Image == null)
            {
                MessageBox.Show("Сначала выберите изображеине!!!");
                return;
            }
            pictureBox.Image = ToGrayScale((Bitmap) originalImage.Clone());
            flowLayoutPanel1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Сначала выберите изображеине!!!");
                return;
            }
            pictureBox.Image = ToSepia((Bitmap)originalImage.Clone());
            flowLayoutPanel1.Refresh();
        }

        private void btn_OrigImage_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Сначала выберите изображеине!!!");
                return;
            }
            pictureBox.Image = originalImage;
            flowLayoutPanel1.Refresh();
        }


       
        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Сначала выберите изображеине!!!");
                return;
            }
            pictureBox.Image = ToNegative(originalImage.Clone() as Bitmap);
            flowLayoutPanel1.Refresh();
        }

        private Bitmap ToNegative(Bitmap Bmp)
        {
            for (int x = 0; x < Bmp.Width; x++)
            {
                for (int y = 0; y < Bmp.Height; y++)
                {
                    Color pixel = Bmp.GetPixel(x, y);
                    pixel = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    Bmp.SetPixel(x, y, pixel);
                }
            }
            return Bmp;
        }

        private Bitmap InvertChanel(Bitmap Bmp, Color channel)
        {
            for (int x = 0; x < Bmp.Width; x++)
            {
                for (int y = 0; y < Bmp.Height; y++)
                {
                    Color pixel = Bmp.GetPixel(x, y);
                    if(channel == Color.Red) pixel = Color.FromArgb(255 - pixel.R, pixel.G, pixel.B);
                    if (channel == Color.Green) pixel = Color.FromArgb(pixel.R, 255 - pixel.G, pixel.B);
                    if (channel == Color.Blue) pixel = Color.FromArgb(pixel.R, pixel.G, 255 - pixel.B);
                    Bmp.SetPixel(x, y, pixel);
                }
            }
            return Bmp;
        }

        private void btnInvertChannel_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Сначала выберите изображеине!!!");
                return;
            }
            switch (comboBox.SelectedItem)
            {
                case "R":
                    pictureBox.Image = InvertChanel(originalImage.Clone() as Bitmap, Color.Red);
                    flowLayoutPanel1.Refresh();
                    break;
                case "G":
                    pictureBox.Image = InvertChanel(originalImage.Clone() as Bitmap, Color.Green);
                    flowLayoutPanel1.Refresh();
                    break;
                case "B":
                    pictureBox.Image = InvertChanel(originalImage.Clone() as Bitmap, Color.Blue);
                    pictureBox.Image = InvertChanel(originalImage.Clone() as Bitmap, Color.Blue);
                    flowLayoutPanel1.Refresh();
                    break;
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Сначала выберите изображеине!!!");
                return;
            }
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColor.BackColor = colorDialog.Color;
                drawColor = colorDialog.Color;
            }
        }

        private void drawBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Сначала выберите изображеине!!!");
                return;
            }
            if (isDrawing)
            {
                isDrawing = false;
                this.Cursor = Cursors.Arrow;
            }
            else
            {
                isDrawing = true;
                this.Cursor = Cursors.PanSW;
            }

        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isMouseDown = true;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true )
            {             
                using (Graphics g = Graphics.FromImage(pictureBox.Image))
                {
                    Pen pen = new Pen(drawColor);
                    pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                    pen.Width = (float) spinBoxBrushWidth.Value;
                    g.FillEllipse(new SolidBrush(drawColor), e.Location.X, e.Location.Y, (float) spinBoxBrushWidth.Value, (float)spinBoxBrushWidth.Value);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                }
                pictureBox.Refresh();
                flowLayoutPanel1.Refresh();          
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }


        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null)
            {
                MessageBox.Show("Сначала выберите изображеине!!!");
                return;
            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image.Save(saveFileDialog.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
