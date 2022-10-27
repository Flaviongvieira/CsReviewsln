using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.Interfaces
{
    public class RealDataBase: IDataAccess
    {
        public String ServerName { get; set; }
        public String DatabaseName { get; set; }

        public string GetPersonFromDb()
        {
            // NB:There would be real Code here to Call Database and retieve a name - I'm hardwiring a value in 
            return "john Walsh";
        }
    }
}
