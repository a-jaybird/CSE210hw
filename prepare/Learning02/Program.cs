using System;

class Program
{
    // Person person = new Person();
    // person._givenName = "Joseph";
    // person._familyName = "Smith";
    // person.ShowWesternName();
    // person.ShowEasternName();
    static void Main(string[] args)
    {
         Resume resume1 =new Resume();
        resume1._name ="Ned Flanders ";
        // resume1._jobs = job1.Display()
        resume1.Display();
        Console.WriteLine("Jobs:");
        Job job1 =new Job();
        job1._jobTitle = "Software Engineer";
        job1._company ="Rackspace";
        job1._startYear = 2012;
        job1._endYear=2014;
        job1.Display();

        Job job2 =new Job();
        job2._jobTitle = "Nyan cat";
        job2._company ="Boogle";
        job2._startYear = 2014;
        job2._endYear=2019;
        job2.Display();

        // Resume resume1 =new Resume();
        // resume1._name ="Ned Flanders ";
        // // resume1._jobs = job1.Display()
        // resume1.Display();

    }
}