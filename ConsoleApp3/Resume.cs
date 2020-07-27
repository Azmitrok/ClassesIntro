using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Resume
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        private DateTime birthDate;
        public int Age
        {
            get
            {
                return (DateTime.Now - this.birthDate).Days / 365;
            }
        }

        public Education Education { get; set; }

        private List<WorkExperience> workExperiences;

        public void Send(string message)
        {

        }

        public void Invite(Vacancy vacancy)
        {
            Send($"Уважаемый {this.LastName} {this.FirstName}! Приглашаем рассмотреть вакансию {vacancy.Title} в компании {vacancy.Company.Name}");
        }

        public void Invite(Company company)
        {
            Send($"Приглашаем на собеседование в компанию {company.Name}");
        }

        public bool HasExperienceIn(string technology)
        {
            foreach (var work in this.workExperiences)
            {
                if (work.Position.Contains(technology.Trim(), StringComparison.OrdinalIgnoreCase)
                    && work.Duties.Contains(technology.Trim(), StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }

        public string Search(string technology)
        {
            StringBuilder sb = new StringBuilder();

            //string str = "";

            foreach (var work in this.workExperiences)
            {
                if (work.Position.Contains(technology.Trim(), StringComparison.OrdinalIgnoreCase))
                    sb.Append(work.Position.Replace(technology, technology.ToUpper() + Environment.NewLine));
                    //str += work.Position.Replace(technology, technology.ToUpper()) + Environment.NewLine;


                if (work.Duties.Contains(technology.Trim(), StringComparison.OrdinalIgnoreCase))
                    sb.Append(work.Duties.Replace(technology, technology.ToUpper()));
            }

            return sb.ToString();
        }

    }
}
