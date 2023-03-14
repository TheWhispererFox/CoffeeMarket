namespace ItemService.Models
{
    public class Item

    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }

        string Image { get; set; }
        double Weight { get; set; }
        double Price { get; set; }
    }
}
