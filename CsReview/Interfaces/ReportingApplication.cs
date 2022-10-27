using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.Interfaces
{
    /*Class representing a reporting application that reads values froma databse
     * This is where THE REAL MAJIC HAPPENS
     * Note I always use a reference to the interface , and never 'RealDatabase' or 'MockDatabase'    
     * Passing references around, instead of classes, means I'm not tied to a particular implementation
     * I can easily change the implmentation class, but interface code doesn't change'*/

    public class ReportingApplication
    {
        public IDataAccess iDb;
        public ReportingApplication(IDataAccess db)
        {
            iDb = db;
        }

        public void Report()
        {
            string nameFromDb = iDb.GetPersonFromDb();
            Console.WriteLine($"Reporting on {nameFromDb}");
        }
    }
}
