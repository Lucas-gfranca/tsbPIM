using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsbPIM.Modelo
{
    public class DropDown
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DropDown(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }


}
