namespace Exercicio_Classe_1_.Entities
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string OldestPerson(Person otherPerson)
        {
            if (Age > otherPerson.Age)
            {
                return Name;
            }
            else
            {
                return otherPerson.Name;
            }
        }
    }
}