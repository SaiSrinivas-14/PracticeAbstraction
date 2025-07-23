using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA.Models.Models;
using PA.Models;

namespace PA.Manager
{
   public class Manager: IManager
    {
        private object _result;
        public Manager(object res)
        {
            _result = res;
        }
        public IResponse Execute()
        {

            return new Response
            {
                Result = _result,
            };
        }
    }
}
