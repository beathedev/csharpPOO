using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_List
{
    public struct Endereco
    {
            public string Rua { get; set; } 
            public string Bairro { get; set; }
            public string Cep { get; set; }
            public string Numero { get; set; }
            public TipoRuaEnum TipoRuaEnum { get; set; }
    }
}