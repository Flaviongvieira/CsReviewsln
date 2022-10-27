using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsReview.Ca2OosDev2
{
    public enum Tier { Hot, Cool }
    public class StorageAccount
    {
        // StorageAccount fields and properties
        protected string storageName;
        public string StorageName
        {
            get { return storageName; }
        }

        protected DateTime createDate;
        public DateTime CreateDate
        {
            get { return createDate; }
        }

        public Tier Tier { get; set; }
        public Uri Uri
        {
            get
            {
                return new Uri($"https://{StorageName}.blob.core.windows.net");
            }
        }

        public List<BlobContainer> blobContainers;
        double storageUsed = 0;

        // default constructor (tier = Hot & createDate = now)
        public StorageAccount(string name)
        {
            storageName = name;
            createDate = DateTime.Now;
            Tier = Tier.Hot;
            blobContainers = new List<BlobContainer>();
        }

        // Method to add a Blobcontainer to the storage list
        public void AddBlob(BlobContainer blob)
        {
            if (blobContainers == null)
            {
                blobContainers.Add(blob);
            }
            else
            {
                if (blobContainers.Contains(blob))
                {
                    throw new ArgumentException($"Blob:{blob.Name} already exists in StorageAccount:{StorageName}");
                }
                else
                {
                    blobContainers.Add(blob);
                }
            }
        }

        // Method to get Account storage used
        public void GetStorageGb()
        {
            foreach (BlobContainer blob in blobContainers)
            {
                storageUsed += blob.StorageGb;
            }
            Console.WriteLine($"StorageAccount:{StorageName} is using {storageUsed} GB");
        }

        // Overide ToString()
        public override string ToString()
        {
            return $"Storage Account Name:{StorageName} - Creation Date:{CreateDate} - Access Tier:{Tier}";
        }

        public void MonthCost()
        {
            const double First50 = 0.0184;
            const double Next450 = 0.0177;
            const double Over500 = 0.0170;
            const double cool = 0.01;

            if (this.Tier == Tier.Cool)
            {
                Console.WriteLine($"Monthly cost: {cool * storageUsed}");
            }
            else
            {
                if (this.storageUsed < 50000)
                {
                    Console.WriteLine($"Monthly cost: {First50 * storageUsed}");
                }
                else
                {
                    if (this.storageUsed < 500000)
                    {
                        Console.WriteLine($"Monthly cost: {Next450 * storageUsed}");
                    }
                    else
                    {
                        Console.WriteLine($"Monthly cost: {Over500 * storageUsed}");
                    }
                }
            }

        }
    }
}
