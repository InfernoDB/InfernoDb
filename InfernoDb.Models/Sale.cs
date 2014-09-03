namespace InfernoDb.Models
{
    using System.ComponentModel.DataAnnotations;
    using System;

   public class Sale
    {
       [Key]
        public int SaleId { get; set; }
        
       public int ProductId { get; set; }

       public decimal UnitPrice { get; set; }

       public DateTime? Date { get; set; }
    }
}
