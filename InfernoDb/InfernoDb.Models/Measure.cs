namespace InfernoDb.Models
{
    public class Measure 
    {
        public int Id { get; set; }

        public string  MeasureName { get; set; }

        public virtual Product Product { get; set; }
    }
}
