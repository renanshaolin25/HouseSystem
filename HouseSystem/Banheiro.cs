using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseSystem
{
    class Banheiro : Comodo
    {
        public bool temChuveiro { get; set; }
        public bool temEspelho { get; set; }
        public bool temVasoSanitario { get; set; }
    }
}
