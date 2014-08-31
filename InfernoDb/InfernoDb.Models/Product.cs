namespace InfernoDb.Models
{
    using System.Collections.Generic;

    public class Product
    {
        private ICollection<Vendor> vendors;
        private ICollection<Measure> measure;

        public Product()
        {
            this.vendors = new HashSet<Vendor>();
            this.measure = new HashSet<Measure>();
        }


        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal  BasePrice { get; set; }

        public virtual ICollection<Vendor> Vendors
        {
            get { return this.vendors;}
            set { this.vendors = value; }
        }

        public virtual ICollection<Measure> Measures
        {
            get { return this.measure; }
            set { this.measure = value; }
        }
    }
}
