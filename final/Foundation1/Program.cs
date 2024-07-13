using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video();
        video1.title = "How to Clean a Cat tree";
        video1.Author ="Paulson Cattree";
        video1.lengthSecs = 359;
        video1.numberOfComments = 3;
        video1.Display();
        Comments comments1 = new Comments();
        for(int d=1; d<= 3; d++){
        comments1.Publish();
        }
        Video video2 = new Video();
        video2.title = "ACDC's Thunderstruck- bardcore cover";
        video2.Author ="Alphabet s0up";
        video2.lengthSecs = 416;
        video2.numberOfComments = 4;
        video2.Display();
        Comments comments2 = new Comments();

        for(int d=1; d<= 4; d++){

        comments2.Publish();
        }
        Video video3 = new Video();
        video3.title = "Best of EFY 2018";
        video3.Author ="LDSYSA";
        video3.lengthSecs = 535;
        video3.numberOfComments = 3;
        video3.Display();
        Comments comments3 = new Comments();
        for(int d=1; d<= 3; d++){
        comments3.Publish();
        }

}
}