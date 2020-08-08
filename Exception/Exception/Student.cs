using System;

namespace Exception
{
    class Student
    {
        string Name;
        string Surname;
        string Cours;
        public Student(string name, string surname, string cours)
        {
            Name = name;
            Surname = surname;
            Cours = cours;
        }
        public void Print()
        {
            try
            {
                Console.WriteLine($"Name: {Name}\nSurname; {Surname}\nCours: {Cours}");
            }
            finally
            {
                if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname))
                {
                    throw new ArgumentNullException("Name and surname cannot be null or empty.");
                }
            }
        }
    }
}
