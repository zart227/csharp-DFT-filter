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
public class Spectr
{

    public static void FourierTransform(float[] xs, int N, float[] an, float[] bn, float[] cn)
    {
        for (int i = 0; i < N/2; i++)
        {
            an[i] = 0;
            bn[i] = 0;
            for (int j = 0; j < N; j++)
            {
                an[i] += (float) ((1 / N) * xs[j]*Math.Cos(2*Math.PI*i*j/N));
                bn[i]+=(float) ((1 / N) * xs[j]*Math.Sin(2*Math.PI*i*j/N));
            }
            cn[i]=(float) Math.Sqrt(an[i]*an[i]+bn[i]*bn[i]);
        }
    }
    public static void InverseFourierTransform(float[]  yk, int N, int n1, int n2, float[] an, float[] bn, float[] cn)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = n1; j < n2; j++)
            {
                yk[i] += (float) (an[j] * Math.Cos(2 * Math.PI * i * j / N) + bn[j] * Math.Sin(2 * Math.PI * i * j / N));
            }
        }
    }
}

}