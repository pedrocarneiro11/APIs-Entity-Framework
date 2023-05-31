using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _10_Introducao_a_APIs_com_Csharp.Entities
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}