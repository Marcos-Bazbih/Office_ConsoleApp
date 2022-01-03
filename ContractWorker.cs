using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_ConsoleApp
{
    internal class ContractWorker
    {
        public string name;
        public string email;
        public string companyName;

        public ContractWorker(string name, string email, string companyName)
        {
            this.name = name;
            this.email = email;
            this.companyName = companyName;
        }
    }
}
