using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fishbot;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace UltimateFishBot.Classes.BodyParts
{


    /* TODO

        Bilder verkleinern Zeit zum Bearbeiten ist zu lang (ca 9 sek ) , Ziel ca 1 sek
        Bilder nichtm ehr auf der festplatte speichern sondern im Arbeitsspeicher halten und nach jedem Auswurf verwerfen.
        Standort auslesen in WOW , wo Stehe ich und Alarma geben + einstellen der Tätigkeit wenn Standort nicht mehr korrekt.
        Auslesen ob flüstern oder GM. Alarm und weitermachen.
        Pixel zum klicken random auswählen, da Liste ist das kein Problem 
        Pixel an MouseMove übergeben 
        MouseMove mit Ear zusammenbringen 
        MouseMove Rechtsklick beibringen
        Wenn System grob läuft Code Review und erste Gedanken um Visuelle Gestaltung

     
         */



    class Program
    {
       // public static bool Wait = false;
        static WaveOutCapabilities Cap;
        static void Main(string[] args)
        {

            var PathFirstImage = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Screenshot1.png";
            var PathSecondImage = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + @"\Screenshot2.png";
            var firstImage = new Bitmap(PathFirstImage, true);
            var secondImage = new Bitmap(PathSecondImage, true);
            Console.WriteLine(firstImage.PixelFormat);
            Console.WriteLine(secondImage.PixelFormat);

            CompareImages compareImages = new CompareImages();
            var coordinateList = compareImages.ImageCompareArray(firstImage, secondImage);
            
            Random rnd = new Random();
            var randomNumber = rnd.Next(0, coordinateList.Count);
            var x = coordinateList[randomNumber].X;
            var y = coordinateList[randomNumber].Y;

            new MouseMove(x, y);
          
            
           
            
            //  // new MouseMove();

            //  var enumerator = new MMDeviceEnumerator();
            //var device =   enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
            //  for (int i = 0; i < WaveOut.DeviceCount; i++)
            //  {
            //      //var cap = WaveOut.GetCapabilities(1);

            //      //Console.WriteLine("{0}: {1}", i, cap.ProductName);
            //     var cap =  enumerator.GetDevice(device.ID);

            //      Console.WriteLine(cap);
            //  }


            // var SndDevice = enumerator.GetDevice(enumerator.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console).ID);

            //var Wait = true;
            //var c = new Ears();
            //int i = 0;
            //while (true)
            //{
            //  Wait  = c.Listen(30000).Result;


            //    Console.WriteLine();
           Console.WriteLine("daniel");
            Console.ReadLine();
        }
             



           

           
        
    }
}
