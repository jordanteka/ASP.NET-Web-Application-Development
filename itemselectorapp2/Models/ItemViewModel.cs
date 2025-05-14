namespace ItemSelectorApp1.Models
{
    public class ItemViewModel
    {
        public List<Item> Items { get; set; }
        public string SelectedItem { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
