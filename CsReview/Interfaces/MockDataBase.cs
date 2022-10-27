using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.Interfaces
{
    // CLASS implementing Inteface for a mock test database - I can use this until i have a real database
    public class MockDataBase: IDataAccess
    {
        public string GetPersonFromDb()
        {
            return "Test User";
        }
    }
}
