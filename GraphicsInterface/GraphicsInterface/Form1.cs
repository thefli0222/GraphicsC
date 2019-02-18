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



namespace GraphicsInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IntPtr image = Emgu.CV.CvInvoke.cvCreateImage(new System.Drawing.Size(400, 300), Emgu.CV.CvEnum.IplDepth.IplDepth_8U, 1);
            
        }

    }
}
