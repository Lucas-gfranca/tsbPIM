using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsbPIM.Modelo
{
    public class ClienteModel
    {
        public int idCliente { get; set; }
        public Boolean clientePj { get; set; }
        public string nomeCliente { get; set; }
        public string foneCliente { get; set; }
        public string cpfCliente { get; set; }
        public string rgCliente { get; set; }
        public string emailCliente { get; set; }
        public DateTime dataNascCliente { get; set; }
        public string sexoCliente { get; set; }
        public string estCivCliente { get; set; }
        public double altura { get; set; }
        public double peso { get; set; }
        public Boolean fumante { get; set; }
        public Boolean cirurgias { get; set; }
        public Boolean doencas { get; set; }
        public string rua { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string complemento { get; set; }
    }
}
