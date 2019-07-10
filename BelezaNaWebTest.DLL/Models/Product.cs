namespace BelezaNaWebTest.Models
{
    public class Product
    {
        public int Sku { get; set; }
        public string Name { get; set; }
        public Inventory Inventory { get; set; }
        public virtual bool IsMarketable
        {
            get
            {
                return (this.Inventory != null && this.Inventory.Quantity > 0);
            }
        }
    }
}