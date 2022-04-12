namespace S6_Exercicio_Listas_1.Entities
{
    class Rent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Rent(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }

        public override string ToString()
        {
            return $"{Room}: {Name}, {Email}";
        }
    }
}
