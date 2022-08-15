using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContaBancariaComExcecao.Entities;

namespace ContaBancariaComExcecao.Entities.Exeptions
{
    internal class DomainExeptions : ApplicationException
    {
        public DomainExeptions(string message) : base(message)
        {
        }
    }
}
