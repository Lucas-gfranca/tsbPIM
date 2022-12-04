using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsbPIM.Modelo
{
    public class ClientesDropDown
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ClientesDropDown(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
