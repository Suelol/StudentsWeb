using System;
using System.Data;
using System.Text.RegularExpressions;

namespace BlazorApp1.Data
{
    public class Students
    {
        public Students(int iD, string surname, string name, string lastName, string group, DateTime dateOfBirth, string photo = "/img/user-icon.png",  bool show = false)
        {
            ID = iD;
            Surname = surname;
            Name = name;
            LastName = lastName;
            Group = group;
            Photo = photo;
            DateOfBirth = dateOfBirth;
            Show = show;
        }

        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Group { get; set; }
        public string Photo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Show { get; set; }

    }
    
}
