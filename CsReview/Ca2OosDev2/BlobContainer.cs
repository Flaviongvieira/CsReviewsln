using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CsReview.Ca2OosDev2
{
    // Access level
    public enum Access { Public, Private }

    // Interface for access level
    public interface IAccessLevel
    {
        public Access Access { get; set; }
    }

    public class BlobContainer: IAccessLevel
    {
        // Class properties and fields
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (Format(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("invalid name format");
                }
            }
        }

        // Method to check name format
        private bool Format(string value)
        {
            return Regex.IsMatch(value, @"^[a-z0-9$]{0,24}$");
        }

        public Access Access { get; set; }
        public double StorageGb { get; set; }

        // default constructor (storage = 0 & access = private)
        public BlobContainer(string name)
        {
            this.Name = name;
            this.Access = Access.Private;
            this.StorageGb = 0;

        }

        // Upload method (size as parmater)
        public void Upload(double size)
        {
            if (size <= 0)
            {
                this.StorageGb += size;
            }
            else
            {
                throw new ArgumentException("Invalid size!");
            }

        }

    }
}
