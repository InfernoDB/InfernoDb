namespace InfernoDb.Models
{
    public class Vendor
    {

        public int Id { get; set; }

        public string  VendorName { get; set; }

        public virtual Product Product { get; set; }

    }
}
