using System;

namespace WindowsFormsApplication1
{
    public enum Gender { Male = 0, Female = 1 }

    public class Employee
    {
        using System;

namespace WindowsFormsApplication1
    {
        public enum Gender { Male = 0, Female = 1 }

        public class Employee
        {
            public string FirstName { get; set; } //имя
            public string Patronymic { get; set; } //отчество
            public string SecondName { get; set; } //фамилия
            public string Post { get; set; } //должность
            public string Degree { get; set; } //ученая степень
            public bool Married { get; set; } //женат
            Gender gender; //пол
            DateTime birthDay; //дата рождения

            public Gender Gender { get { return this.gender; } }
            public DateTime BirthDay { get { return this.birthDay; } }
            public int Age
            {
                get
                {
                    DateTime now = DateTime.Today;
                    int age = now.Year - this.birthDay.Year;
                    if (now < this.birthDay.AddYears(age)) age--;
                    return age;
                }
            }

            private Employee() { }

            public Employee(string firstName, string Patronymic, string secondName, Gender gender, DateTime birthDay, bool married)
            {
                this.FirstName = firstName;
                this.Patronymic = Patronymic;
                this.SecondName = secondName;
                this.gender = gender;
                this.birthDay = birthDay;
                this.Married = married;
            }

            public Employee(string firstName, string Patronymic, string secondName, Gender gender, DateTime birthDay, bool married, string post, string degree)
                : this(firstName, Patronymic, secondName, gender, birthDay, married)
            {
                this.Post = post;
                this.Degree = degree;
            }
        }
    }


    private Employee() { }

        public Employee(string firstName, string Patronymic, string secondName, Gender gender, DateTime birthDay, bool married)
        {
            this.FirstName = firstName;
            this.Patronymic = Patronymic;
            this.SecondName = secondName;
            this.gender = gender;
            this.birthDay = birthDay;
            this.Married = married;
        }

        public Employee(string firstName, string Patronymic, string secondName, Gender gender, DateTime birthDay, bool married, string post, string degree)
            : this(firstName, Patronymic, secondName, gender, birthDay, married)
        {
            this.Post = post;
            this.Degree = degree;
        }
    }
}
