using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sondaggio
{
    public class ClsCategoria //Romani Anastasia
    {
        private string _nome;

        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception();
                else
                    _nome = value;
            }
        }

        public ClsCategoria()
        {
        }

        public ClsCategoria(string nome)
        {
            Nome = nome;
        }
    }
}
