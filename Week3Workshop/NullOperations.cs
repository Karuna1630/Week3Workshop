using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Workshop
{
    internal class NullOperations
    {

        public void PerformNullChecks()
        {
            
            string userName = null;

            string result = (userName == null) ? "Username is not available" : userName;

            Console.WriteLine(result);

           //Null coalescing operator (??)
            string result2 = userName ?? "Username is not available";
            Console.WriteLine(result2);
        }
    }

}

