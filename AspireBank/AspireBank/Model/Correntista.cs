using System;
using System.Collections.Generic;
using System.Text;

namespace AspireBank.Model
{
    public class Correntista
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string cpf { get; set; }
        public DateTime data_nasc { get; set; }
    }
}
