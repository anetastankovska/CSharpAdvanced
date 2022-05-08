using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface IAdmin
    {
        public ICompany Company { get; set; }
    }
}
