using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wallpaper_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            //int _SCREENWIDTH = Screen.PrimaryScreen.Bounds.Width;
            //int _SCREENHEIGHT = Screen.PrimaryScreen.Bounds.Height;
            //int red, green, blue;
            //string current_wp = SetWallpaper.GetCurrentWallpaperPath();
            //Bitmap bitmap = new Bitmap(current_wp);
            ////Image img = Image.FromFile(current_wp);
            ////pictureBox1.Image = img;

            //Color c;
            //for (int i = 0; i <_SCREENWIDTH; i++)
            //{
            //    for (int j = 0; j < _SCREENHEIGHT; j++)
            //    {
            //        c = bitmap.GetPixel(i, j);
            //        red = c.R;
            //        green = c.G;
            //        blue = c.B;
            //    }
            //}

            //for (int i = 0; i < _SCREENWIDTH; i++)
            //{
            //    for (int j = 0; j < _SCREENHEIGHT; j++)
            //    {
            //        if()
            //        bitmap.SetPixel(i, j,Color.);                    
            //    }
            //}

            var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                               Screen.PrimaryScreen.Bounds.Height,
                               PixelFormat.Format32bppArgb);

            // Create a graphics object from the bitmap.
            var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

            // Take the screenshot from the upper left corner to the right bottom corner.
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                        Screen.PrimaryScreen.Bounds.Y,
                                        0,
                                        0,
                                        Screen.PrimaryScreen.Bounds.Size,
                                        CopyPixelOperation.SourceCopy);

            // Save the screenshot to the specified path that the user has chosen.
            bmpScreenshot.Save("ss.png", ImageFormat.Png);

            Bitmap bmp = (Bitmap)Bitmap.FromFile(Application.StartupPath + "\\ss.png");
            string apth = Application.StartupPath + "\\ss.png";
            textBox1.Text = apth;

            string[] dizi = { "Rotate180FlipNone",  "Rotate180FlipX",  "Rotate180FlipXY",  "Rotate180FlipY",
                              "Rotate270FlipNone",  "Rotate270FlipX",  "Rotate270FlipXY",  "Rotate270FlipY",
                              "Rotate90FlipNone",   "Rotate90FlipX",   "Rotate90FlipXY",   "Rotate90FlipY",
                              "RotateNoneFlipNone", "RotateNoneFlipX", "RotateNoneFlipXY", "RotateNoneFlipY" };

            bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);//
            bmp.Save(dizi[0] + ".png", ImageFormat.Png);
            bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
            bmp.Save(dizi[1] + ".png", ImageFormat.Png);
            //bmp.RotateFlip(RotateFlipType.Rotate180FlipXY);
            //bmp.Save(dizi[2] + ".png", ImageFormat.Png);
            bmp.RotateFlip(RotateFlipType.Rotate180FlipY);
            bmp.Save(dizi[3] + ".png", ImageFormat.Png);

            //bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
            //bmp.Save(dizi[4] + ".png", ImageFormat.Png);
            bmp.RotateFlip(RotateFlipType.Rotate270FlipX);
            bmp.Save(dizi[5] + ".png", ImageFormat.Png);
            //bmp.RotateFlip(RotateFlipType.Rotate270FlipXY);
            //bmp.Save(dizi[6] + ".png", ImageFormat.Png);
            //bmp.RotateFlip(RotateFlipType.Rotate270FlipY);
            //bmp.Save(dizi[7] + ".png", ImageFormat.Png);

            //bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            //bmp.Save(dizi[8] + ".png", ImageFormat.Png);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipX);
            bmp.Save(dizi[9] + ".png", ImageFormat.Png);
            //bmp.RotateFlip(RotateFlipType.Rotate90FlipXY);
            //bmp.Save(dizi[10] + ".png", ImageFormat.Png);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipY);
            bmp.Save(dizi[11] + ".png", ImageFormat.Png);

            //bmp.RotateFlip(RotateFlipType.RotateNoneFlipNone);
            //bmp.Save(dizi[12] + ".png", ImageFormat.Png);
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            bmp.Save(dizi[13] + ".png", ImageFormat.Png);
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            bmp.Save(dizi[14] + ".png", ImageFormat.Png);
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            bmp.Save(dizi[15] + ".png", ImageFormat.Png);
            
        }
    }
}
