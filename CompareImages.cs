using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishbot
{
    class CompareImages
    {


        public List<Coordinates> ImageCompareArray(Bitmap firstImage, Bitmap secondImage)
        {
            bool flag = true;
            string firstPixel;
            string secondPixel;
            List<Coordinates> ArrayCoordinatesDistinguishImages = new List<Coordinates>();

            if (firstImage.Width == secondImage.Width
                && firstImage.Height == secondImage.Height)
            {
                for (int i = 0; i < firstImage.Width; i++)
                {
                    for (int j = 0; j < firstImage.Height; j++)
                    {
                        firstPixel = firstImage.GetPixel(i, j).ToString();
                        secondPixel = secondImage.GetPixel(i, j).ToString();
                        if (firstPixel != secondPixel)
                        {
                            flag = false;
                           // Console.WriteLine(i + "/ " + j);
                          Coordinates c= new Coordinates(i, j);
                            ArrayCoordinatesDistinguishImages.Add(c);
                            break;
                        }
                    }
                }

            }

          return  ArrayCoordinatesDistinguishImages;
        }
    }
}

public class Coordinates
{
    public int X;
    public int Y;

    public Coordinates(int x, int y)
    {
        X = x;
        Y = y;

    }
}