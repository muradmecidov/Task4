namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student telebe1 = new Student("Murad", "Mecidov", "109a3", 81);
            Student telebe2 = new Student("Ali", "Novruzov", "109a3", 60);
            telebe1.GetInfo();
            telebe2.GetInfo();
            telebe1.GetDiplomDegree();
            telebe2.GetDiplomDegree();
            Console.ReadLine();
        }
    }
    class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;


        public Student(string name, string surname, string group, byte point)
        {
            this.Name = name;
            this.Surname = surname;
            this.Group = group;
            this.Point = point;
        }


        public void Getİnfo()
        {
            // Console.WriteLine($"Name;Surnam;Group;Point");

           // Console.WriteLine( this.Name);
           // Console.WriteLine( this.Surname);
           // Console.WriteLine( this.Group);
           // Console.WriteLine( this.Point);
        }



        public void GetDiplomDegree()
        {
            if (this.Point < 65)
            {
                Console.WriteLine("diplom yoxdu");
            }
            else if (this.Point < 80)
            {
                Console.WriteLine(" adi diplom");
            }
            else if (this.Point < 90)
            {
                Console.WriteLine(" sheref diplomu");
            }
            else
            {
                Console.WriteLine("yuksek sheref");
            }
        }
    }
    }
