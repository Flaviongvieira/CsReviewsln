using CsReview.AbstractClass;
using CsReview.AccessModifiers;
using CsReview.Ca2OosDev2;
using CsReview.Generics;
using CsReview.Indexer;
using CsReview.InheritancePolymorphism;
using CsReview.Interfaces;
using CsReview.StaticMethod;
using System;
using System.Collections.Generic;

namespace CsReview
{
    internal class Test
    {
        static void Main()
        {
            /****************** Access Modifiers ******************/
            Console.WriteLine("Access Modifiers");
            BaseClass obj = new BaseClass();
            //obj.BPrivate = 1;    // ERROR : Nobody can view private vars of another class
            //obj.BProtected = 1;  // ERROR : only code inside derived class has access to protected vars of base class
            obj.BPublic = 1;     //OK : Everybody has access to public members of any class
            Console.WriteLine($"BaseClass obj public propertie: {obj.BPublic}");
            obj.publicMethod();
            DerivedClass obj2 = new DerivedClass();
            Console.WriteLine($"BaseClass obj public propertie: {obj2.BPublic}");
            obj2.publicMethod();
            Console.WriteLine();

            /****************** Static Class ******************/
            Console.WriteLine("Static Class");
            int ans1 = StaticClass.Add(10, 6);
            int ans2 = StaticClass.Subtract(10, 6);
            Console.Write($"Answer 1 is {ans1}");
            Console.Write($"Answer 2 is {ans2}");
            Console.WriteLine();

            /****************** Abstract Class ******************/
            Console.WriteLine("Abstract Class");
            Cat c = new Cat();
            c.Breathe();
            c.Move();

            AnimalAbstractClass a = new Cat();
            a.Move();    //References as an animal .. but it REALLY is a cat
            Console.WriteLine();

            /****************** Inhecitance and Polymorphism Class ******************/
            Console.WriteLine("Inhecitance and Polymorphism Class");
            List<Person> people = new List<Person>()
            {
                new Person(),
                new Trainer(),
                new Student()
            };
            foreach (Person p in people)
            {
                p.PrintName();
            };
            Console.WriteLine();

            /****************** Interfaces ******************/
            Console.WriteLine("Interfaces");
            // MockDataBase example
            IDataAccess iDb_MDB = new MockDataBase();
            ReportingApplication app_MDB = new ReportingApplication(iDb_MDB);
            app_MDB.Report();

            // RealDataBase example
            IDataAccess iDb = new RealDataBase();
            ReportingApplication app_iDb = new ReportingApplication(iDb);
            app_iDb.Report();
            Console.WriteLine();

            /****************** Collections and Generics ******************/
            Console.WriteLine("Collections and Generics");

            // Generic Methods
            // Example 1 <int>
            int x = 10, y = 20;
            GenericMethodsSample.Swap<int>(ref x, ref y);
            Console.WriteLine($"x:10->{x} y:20->{y}");
            // Example 2 <string>
            string str1 = "First", str2 = "second";
            GenericMethodsSample.Swap<string>(ref str1, ref str2);
            Console.WriteLine($"str1:First->{str1} str2:second->{str2}");
            // Example 3 <int, string>
            double e = 1.0, f = 2.0;
            int z = GenericMethodsSample.ReturnSomething<int, string>(x, y, str1);
            Console.WriteLine($"z:{z}");
            double g = GenericMethodsSample.ReturnSomething<double, string>(e, f, str1);
            Console.WriteLine($"g:{g}");

            // Generic Classes
            // Example 1
            Helper1<int> h1 = new Helper1<int>();
            var e1 = new Helper1<string>();
            e1.Method1("Hello World");
            h1.Method1(99);
            // Example 2
            var h2 = new Helper2<int, string>();
            var ret = h2.Method1(99);
            h2.Method2(99, "A string");

            //Generic List Class
            // Declare a list of type int.
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(99, 0);
            // Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();
            list2.Add("JOHN", 0);
            // Declare a list of type ExampleClass.
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass(), 0);

            Console.WriteLine();

            /****************** Indexer ******************/
            Console.WriteLine("Indexer");
            
            WebConnection wc = new WebConnection(10);
            try
            {
                wc[wc.FreeConnection()] = "http://www.google.ie";
                wc[wc.FreeConnection()] = "www.eir.ie";
                wc[wc.FreeConnection()] = "www.nasa.gov.us";
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine(ie.Message);
            }

            for (int i = 0; i < wc.Length(); i++)
            {
                Console.WriteLine($"{i} : {wc[i]}");
            }

            Console.WriteLine();
            /****************** CA2 OOSDEV2 ******************/
            Console.WriteLine("CA2 OOSDEV2");
            try
            {
                // Test BlobContainer class
                Console.WriteLine("Test BlobContainer class");
                BlobContainer b1 = new BlobContainer("test1$");
                Console.WriteLine(b1.Name);
                Console.WriteLine(b1.Access);
                Console.WriteLine(b1.StorageGb);
                BlobContainer b2 = new BlobContainer("test2");
                Console.WriteLine(b1.Name);
                /*BlobContainer b2 = new BlobContainer("test2@");
                Console.WriteLine(b1.Name);*/

                // Test StorageAccount class
                Console.WriteLine();
                Console.WriteLine("Test StorageAccount class");
                StorageAccount s1 = new StorageAccount("testS");
                /*s1.StorageName = "testchangename";*/
                Console.WriteLine(s1.StorageName);
                Console.WriteLine(s1.CreateDate);
                Console.WriteLine(s1.Tier);
                Console.WriteLine(s1);

                // Test Add Blob container in Storage account
                Console.WriteLine();
                Console.WriteLine("Test Add Blob container in Storage account");
                s1.AddBlob(b1);
                s1.AddBlob(b2);
                /*s1.AddBlob(b2);*/
                foreach (BlobContainer b in s1.blobContainers)
                {
                    Console.WriteLine(b.Name);
                }

                // Test Method to get storage used and Montlhy cost
                Console.WriteLine();
                Console.WriteLine("Test Method to get storage used and Montlhy cost");
                b1.StorageGb = 430000;
                b2.StorageGb = 130000;
                /*s1.Tier = Tier.Cool;*/
                s1.GetStorageGb();
                s1.MonthCost();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
