using System;
using System.Net.Mail;

namespace ConsoleApp3
{
    public class Vacancy
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Company Company { get; set; }

        private VacancyStatus status;
        public void ApplyFor(Resume resume)
        {
            if (resume == null)
                throw new ArgumentNullException(nameof(resume));

            if (status != VacancyStatus.Active)
                throw new Exception("Неправильный статус вакансии");

            Send();
        }

        public void Publish()
        {
            if(status != VacancyStatus.Draft)
                throw new Exception("Неправильный статус вакансии");

            status = VacancyStatus.Active;
            // webSite.AddVacancy();
        }

        private void Send()
        {
            // send via email
        }
    }
}