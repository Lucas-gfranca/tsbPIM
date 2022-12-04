using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsbPIM.Modelo
{
    public class FuncionarioModel
    {
        public int funcId { get; set; }
        public string funcNome { get; set; }
        public string cargo { get; set; }
        public DateTime funcDataNasc { get; set; }
        public string funcFone { get; set; }
        public string funcSexo { get; set; }
        public string funcCpf { get; set; }
        public string funcEstCiv { get; set; }
        public string funcRg { get; set; }
        public string funcCep { get; set; }
        public string funcEmail { get; set; }
    }
}
