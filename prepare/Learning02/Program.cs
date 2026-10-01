using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Mojang";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2011;
        job1._endYear = 2026;
  
        Job job2 = new Job();
        job2._company = "EA";
        job2._jobTitle = "Sales Representative";
        job2._startYear = 1995;
        job2._endYear = 2020;


        Resume resume1 = new Resume();
        resume1._name = "Billy Bob";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}