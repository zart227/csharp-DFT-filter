using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DigitalFiltering
{
    public partial class Form1 : Form
    {
        const int N = 500;
        float[] xk = new float[N];
        float[] yk = new float[N];
        float[] an = new float[N/2];
        float[] bn = new float[N/2];
        float[] cn = new float[N/2];
        //Pen p = new Pen(Color.Black);
        //float[] tmp;
        public Form1()
        {
            InitializeComponent();
        }

        public void Draw(int k, int N, PointF pt0, PointF ptmin, PointF ptmax, float[] xs, PictureBox pb)
        {
            Graphics gr = pb.CreateGraphics();
            
            float h = pb.Height;
            float w = pb.Width;
            float x, y, y1, y2, x1, x2;
            float K;
            
            PointF scaleXY;
            //scaleXY = new PointF(ptmax.X / 10, ptmax.Y * 2);
            scaleXY = new PointF(((w - 2 * pt0.X) / (ptmax.X - ptmin.X)), ((h) / (ptmax.Y - ptmin.Y)));

            DrawAxes(k, N, pt0, scaleXY, ptmax, pb);
            
            Pen p = new Pen(Color.Red);
          //  scaleXY= new PointF (((w - 2*pt0.X) / (ptmax.X - ptmin.X)),((h) / (ptmax.Y - ptmin.Y)));

            if (k==1) K = ptmax.X - 1;
            else K = ptmax.X;
            
            for (int i = 0; i < K; i++)
            {
                if (k==1) { y1 = xs[i]; y2 = xs[i + 1]; x1 = i; x2 = i + 1; }
                else { y1 = 0; y2 = xs[i]; x1 = i; x2 = i; }
                x = x1 * scaleXY.X + pt0.X;
                y = pt0.Y - y2 * scaleXY.Y;
                gr.DrawLine(p, x1 * scaleXY.X + pt0.X, pt0.Y - (y1 * scaleXY.Y), pt0.X + x2 * scaleXY.X, pt0.Y - y2 * scaleXY.Y);
               
            }
            gr.Dispose();
        }

        public void DrawAxes(int k, int N, PointF pt0, PointF scaleXY, PointF ptmax, PictureBox pb)
        {
            Graphics gr = pb.CreateGraphics();
            Pen p = new Pen(Color.Black);
            //p.Color = Color.Black;
            float h = pb.Height;
            float w = pb.Width;
            float dx = scaleXY.X;
            float dy = scaleXY.Y;
            float x = 0;
            float y = 0;
            float y1,y2;

            //tmp = new float[(int)scaleXY.X];
            gr.DrawLine(p, pt0.X, 0, pt0.X, h);
            gr.DrawLine(p, pt0.X, pt0.Y, w - pt0.X, pt0.Y);
            if ((k == 1) && (N == 5)) { y1 = 0; y2 = h; }
            else { y1 = pt0.Y + 6; y2 = pt0.Y - 6; }
            //p.Width = 2F;
            for (int i = 0; i <= N; i++)
            {
                
                x = dx * ptmax.X * i / N;
               // tmp[i] = x;
                gr.DrawLine(p, x + pt0.X, y1, x + pt0.X, y2);

            }
            for (int i = 0; i < ptmax.Y*2; i++)
            {
                gr.DrawLine(p, pt0.X, y, pt0.X+10, y);
                y += dy;
            }
            gr.Dispose();
        }

        /*
        public void FourierTransform(float[] xs, float[] an, float[] bn, float[] cn)
        {
            float K = 0.002f;
            for (int i = 0; i < 250; i++)
            {
                an[i] = 0;
                bn[i] = 0;
                for (int j = 0; j < 500; j++)
                {
                    an[i] = an[i] + (float)(K * xs[j] * Math.Cos(2 * Math.PI * i * j *K));
                    bn[i] = bn[i] + (float)(K * xs[j] * (float)Math.Sin(2 * Math.PI * i * j *K));
                }
                cn[i] = (float)Math.Sqrt(an[i] * an[i] + bn[i] * bn[i]);
            }
        }
        public void InverseFourierTransform(float[] yk, int n1, int n2, float[] an, float[] bn, float[] cn)
        {
            for (int i = 0; i < 500; i++)
            {
                yk[i] = 0;
                for (int j = n1; j <= n2; j++)
                {
                    yk[i] += (float)(an[j] * Math.Cos(2 * Math.PI * i * j / 500) + bn[j] * Math.Sin(2 * Math.PI * i * j / 500));
                }
            }
        }        
        */
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
           // Show the Open File dialog. If the user clicks OK, load the
            // file that the user chose.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (BinaryReader b = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.Open)))
	            {
                    this.Text = "Цифровая фильтрация методом ДПФ";
                    int pos = 0;
                    int i = 0;
	                float length = b.BaseStream.Length;
                    while (pos < length)
	                {
                         
                        xk[i] = b.ReadSingle();
                        listBox1.Items.Add(Convert.ToString(i+1) + "       " + Convert.ToString(xk[i]));
                        i++;	               
		                pos += sizeof(float);
                        
	                }
                    b.Close();
                    signalButton.Enabled = true;
                    spectrButton.Enabled = true;
                    dfButton.Enabled = true;
                    
                    int k = openFileDialog1.FileName.LastIndexOf('\\');
                    this.Text += "              " + openFileDialog1.FileName.Substring(k + 1);
                    b.Dispose();
                    openFileDialog1.Reset();
	            }
            }
        }

        private void signalButton_Click(object sender, EventArgs e)
        {
            //float x0 = 10;
            float h = signalPictureBox.Height;
            /*float xmax = 500;
            //float xmin = 0;
            //float ymax =(float) Math.Round(xk.Max());
            //if (ymax < xk.Max()) ymax++;
            //float ymin = -ymax;*/
            PointF pt0 = new PointF(10, h/2);
            PointF ptmax = new PointF(N, ((float)Math.Round(xk.Max())));
            if (ptmax.Y < xk.Max()) ptmax.Y++;
            PointF ptmin = new PointF(0, -ptmax.Y);
            signalPictureBox.Refresh();
            //DrawAxes(x0, y0, xmax / 50, ymax * 2, baseBandPictureBox);
            Draw(1, 10, pt0, ptmin, ptmax, xk, signalPictureBox);
        }

        private void spectrButton_Click(object sender, EventArgs e)
        {
            
            Spectr.FourierTransform(xk, N, an, bn, cn);
            for (int i = 0; i < N/2; i++)
            {
                listBox2.Items.Add(Convert.ToString(i+1) + "       " + Convert.ToString(cn[i]));
            }
            PointF pt0 = new PointF(10, spectrPictureBox.Height-20);
            PointF ptmin = new PointF(0, 0);
            PointF ptmax = new PointF(N/2, 0.5F);
            spectrPictureBox.Refresh();
            Draw(0, 5, pt0, ptmin, ptmax, cn, spectrPictureBox);

        }

        private void dfButton_Click(object sender, EventArgs e)
        {
            int n1=35;
            int n2=45;
            Spectr.InverseFourierTransform(yk, N, n1, n2, an, bn, cn);
            
            for (int i = 0; i < N; i++)
            {
                listBox3.Items.Add(Convert.ToString(i+1) + "       " + Convert.ToString(yk[i]));
            }
            PointF pt0 = new PointF(10, dfPictureBox.Height/2);
            PointF ptmin = new PointF(0, -1);
            PointF ptmax = new PointF(N, 1);
            dfPictureBox.Refresh();
            Draw(1, 5, pt0, ptmin, ptmax, yk, dfPictureBox);
        }

        }
    }

