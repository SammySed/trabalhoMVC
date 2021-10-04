using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Trabalho.Models
{
    public class Aluno
    {
        public long AlunoId { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public string Termo { get; set; }
    }
}