using System;

namespace S15_Exercicio_Generics_2.Entities
{
    class Log
    {
        public string Name { get; set; }
        public DateTime Moment { get; set; }

        public Log(string name, DateTime moment)
        {
            Name = name;
            Moment = moment;
        }

        public override bool Equals(object obj)
        {
            return obj is Log log &&
                   Name == log.Name;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
