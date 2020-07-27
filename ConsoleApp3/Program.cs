using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume resume = new Resume();
            resume.LastName = "Альхимович";
            resume.FirstName = "Дмитрий";

            Resume resume2 = new Resume();

            List<Resume> resumes = new List<Resume> { resume, resume2 };

            var dotNetTechnology = ".net";
            var dotNetDevelopers = resumes.Where(r => r.HasExperienceIn(dotNetTechnology));         

            Vacancy vacancy = new Vacancy();
            var epam = new Company { Name = "Epam" };
            vacancy.Company = epam;
            vacancy.Title = ".Net Developer (EdTech)";

            resume.Invite(vacancy);

            resume.Invite(epam);

            vacancy.ApplyFor(resume);
        }

    }
}
