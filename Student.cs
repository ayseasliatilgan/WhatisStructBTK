namespace BTKAkademi
{
    // Describe
    public struct Student
    {
        // Constructor method
        public Student(int number, string name, string surname, bool gender = false)
        {
            //  when you write like this Alternative usage 2 worked
            // Console.WriteLine("Automatically worked");
            Number = number;
            Name = name;
            Surname = surname;
            Gender = gender;
        }
        // get - set used for reading and writing
        //public int Number { get; set; } // Property
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public bool Gender { get; set; }


        public int Number { get; set; } // Property
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Gender { get; set; }

        // Override -Geçersiz Kılmak / ezmek
        public override string ToString()
        {
            return $"{Number,-5} " +
                $"{Name,-10} " +
                $"{Surname,-10} " +
                string.Format("{0,-8}", Gender == false ? "Bay" : "Bayan");
        }
    }
}