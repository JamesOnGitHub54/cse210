using System;

class Program
{
    static void Main(string[] args)
    {
        /// Allison Rose
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2019";
        job1._endYear = "2022";

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = "2022";
        job2._endYear = "2023";

        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);


        /// Nacho Libre
        Job job3 = new Job();
        job3._jobTitle = "Superstar";
        job3._company = "World Wrestling Entertainment";
        job3._startYear = "2024";
        job3._endYear = "2028";

        Resume resume2 = new Resume();
        resume2._name = "Nacho Libre";
        resume2._jobs.Add(job3);

        ///Display resumes.
        resume1.DisplayResume();
        Console.WriteLine();
        resume2.DisplayResume();
        

    }
}