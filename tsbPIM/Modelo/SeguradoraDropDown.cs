using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsbPIM.Modelo
{
    public class SeguradoraDropDown
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SeguradoraDropDown(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}

