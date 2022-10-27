using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.Interfaces
{
    /* The following code shows the power of interfaces
     * Pretend i want to write an application that accesses data
     * from a database, but the database does not exist yet (it will 
     * be created at a later point)
     *
     * Using interfaces I 
     * (1) can define an interface that represents the database functionality i need
     * (2) create a mock Database class that implements that interface
     * (3) I can now use this mock database class to develop my app (eventhough there is no database yet)
     * (4) at a later stage, when the real database is available I can easily swap to using it, by 
     * instantiating the real database instead of the mock one*/


    public interface IDataAccess
    {
        // INTERFACE to represent some databse functionality
        public string GetPersonFromDb();
    }
}
