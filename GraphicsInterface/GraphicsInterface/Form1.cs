using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using System.Threading;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.IO;
using System.Collections;

namespace GraphicsInterface
{
    public partial class Form1 : Form
    {

        Thread thread;
        private Data fullData;
        private Entities entities;
        private ArrayList entitiesState;


        public Form1()
        {
            //StreamReader sr = File.OpenText("C:/Users/fredr/Documents/GitHub/GraphicsC/GraphicsInterface/GraphicsInterface/output.txt");
            StreamReader sr = File.OpenText("C:/Users/Johannes/Desktop/AI proj/GraphicsC/GraphicsInterface/GraphicsInterface/output.txt");
            string[] text = sr.ReadToEnd().Split('B');

            entities = new Entities(text[0]);

            fullData = new Data(text[1]);

            ArrayList entitiesState = entities.getEntities();

            InitializeComponent();
            
        }


        private void image()
        {
            int width = 640, height = 320;
            Bitmap bmp = new Bitmap(width, height);

            Random rand = new Random();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int a = rand.Next(256);
                    int r = rand.Next(256);
                    int g = rand.Next(256);
                    int b = rand.Next(256);

                    bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            graphicsOutput.Image = bmp;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            image();
        }

        private void WorkThreadFunction()
        {
            try
            {
                for (int i = 0; i < 100; i++)
                    image();
            }
            catch
            {
            }
        }
        Image<Bgr, Byte> img1;
        private void graphicsOutput_Click(object sender, EventArgs e)
        {

            img1 = new Image<Bgr, Byte>(1000, 900, new Bgr(255, 255, 255));
            graphicsOutput.Image = img1.Bitmap;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            textBox2.Text = "" + (int.Parse(textBox2.Text) + 1);

            entities.updateWithTick(fullData.getTickInfo(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
            entitiesState = entities.getEntities();

            foreach(Entity entity in entitiesState){
                int xPos = (int)entity.PosX;
                int yPos = (int)entity.PosY;
                float rotation = entity.Rot;

                Point p = new Point(xPos, yPos);
                Size size = new Size(20, 10);
                RotatedRect rects = new RotatedRect(p, size, rotation);
                img1.Draw(rects, new Bgr(0, 0, 0), -1);
            }

            graphicsOutput.Image = img1.Bitmap;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thread.Abort();
        }

    }
}
