using System;

namespace ProjetoOportunidade.Entities.Exceptions
{
    //DomainExeption é uma subclasse de ApplicationException
    internal class DomainExeption : ApplicationException
    {
        //Tem um construtor recebendo um string message, e repassa essa mensagem para o construtor da classe ApplicationException
        public DomainExeption(string message) : base(message) { }


    }
}
