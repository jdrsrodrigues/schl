using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schl.domain.Entities
{
    public class Entidade
    {
        public int Codigo { get; set; }
        public string NumeroCnpj { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataExclusao { get; set; }
        public bool Ativo { get; set; }
    }
}
