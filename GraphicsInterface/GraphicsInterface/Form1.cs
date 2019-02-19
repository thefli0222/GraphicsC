﻿using System;
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
        private bool isPlaying = false;
        private Thread fpsThreadVar;
        private int width, height;
        private int centerX, centerY;
        private int centerIndex;


        public Form1()
        {
            width = 1000;
            height = 900;
            centerX = width/2;
            centerY = height/2;
            InitializeComponent();
            StreamReader sr = File.OpenText("C:/Users/Johannes/Desktop/AI proj/GraphicsC/GraphicsInterface/GraphicsInterface/output.txt");
            string[] text = sr.ReadToEnd().Split('B');
            fpsThreadVar = new Thread(new ThreadStart(fpsThread));
            fpsThreadVar.Start();
            entities = new Entities(text[0]);
            centerIndex = -1;


            fullData = new Data(text[1]);

            ArrayList entitiesState = entities.getEntities();
            img1 = new Image<Bgr, Byte>(1000, 900, new Bgr(255, 255, 255));
            graphicsOutput.Image = img1.Bitmap;

            List<int> indexList = new List<int>();
            foreach (Entity entity in entitiesState)
            {
                indexList.Add((int)entity.Index);
            }

            foreach(int item in indexList)
            {
                EntitySelected.Items.Add(item);
            }
           


        }


        public void fpsThread()
        {
            int currentValue = 0;
            while (true) {
                if (isPlaying)
                {


                    if(centerIndex >= 0)
                    {
                        centerX = (int)(((Entity)entitiesState[centerIndex]).PosX);
                        centerY = (int)(((Entity)entitiesState[centerIndex]).PosY);
                    }
                    else
                    {
                        centerX = width / 2;
                        centerY = height / 2;
                    }


                    img1 = new Image<Bgr, Byte>(width, height, new Bgr(255, 255, 255));
                    //t.Text = "" + (int.Parse(t.Text) + 1);
                    currentValue++;
                    if(currentValue > 7000)
                    {
                        currentValue = 0;
                    }
                    entities.updateWithTick(fullData.getTickInfo(0, currentValue));
                    entitiesState = entities.getEntities();

                    foreach (Entity entity in entitiesState)
                    {
                        int xPos = width/2 + (int)entity.PosX - centerX;
                        int yPos = height/2 + (int)entity.PosY - centerY;
                        float rotation = entity.Rot;

                        Point p = new Point(xPos, yPos);
                        Size size = new Size(20, 10);
                        RotatedRect rects = new RotatedRect(p, size, rotation);
                        img1.Draw(rects, new Bgr(0, 0, 0), -1);
                    }

                    graphicsOutput.Image = img1.Bitmap;
                    System.Threading.Thread.Sleep(10);
                }
                else
                {
                    currentValue = 0;
                    System.Threading.Thread.Sleep(500);
                }
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
            isPlaying = true;
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
            isPlaying = false;
        }
  
        private void button4_Click_1(object sender, EventArgs e)
        {
            EntitySelected.SelectedIndex = -1;
        }

        private void EntitySelected_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            string text = EntitySelected.GetItemText(EntitySelected.SelectedItem);
         
            if(!text.Equals("")){
                centerIndex = int.Parse(text) - 1;

           
            }
            else
            {
                centerIndex = -1;
            }
           

        }
    }
}
