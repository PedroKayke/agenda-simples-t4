using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSimples
{
    internal class contato
    {
        private string primeiroNome;
        private string sobrenome;
        private string telefone;

        public string PrimeiroNome
        {
            get { return primeiroNome; }    
            set { primeiroNome = value; }   
        }

        public string Sobrenome
        { 
            get { return sobrenome; }
            set { sobrenome = value; }
        }
         public string Telefone
        {
            get { return telefone; }
                        set
            {
                if(value.Length == 11)
                {
                    Telefone = value;
                }
                else
                {
                    Telefone = "00-00000-0000";
                }
            }
        }
        public contato()
        {
            PrimeiroNome = "José";
            Sobrenome = "Da Silva";
            Telefone = "11-91234-5678";
        }

        public contato(string primeironome, string sobrenome, string telefone)
        {
            PrimeiroNome = primeironome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        public override string ToString()
        {
            string saida = String.Empty; 
        }
    }
}
