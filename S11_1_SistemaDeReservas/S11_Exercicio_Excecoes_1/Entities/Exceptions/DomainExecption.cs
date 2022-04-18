using System;

namespace S11_Exercicio_Excecoes_1.Entities.Exceptions
{
    class DomainExecption : ApplicationException
    {
        public DomainExecption(string message) : base(message)
        {
        }
    }
}
