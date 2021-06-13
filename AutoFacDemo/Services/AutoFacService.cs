using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoFacDemo.Services
{
    public class AutoFacService : IAutoFacService
    {
        public string getString()
        {
            return "This string is from AutoFacService";
        }
    }
}
