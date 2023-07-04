using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Company";
        job1._startYear = 2020;
        job1._endYear = 2021;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Team Lead";
        job2._company = "Company 2";
        job2._startYear = 2018;
        job2._endYear = 2019;
        job2.Display();

        Resume resume = new Resume();
        resume._name = "Jarius";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}