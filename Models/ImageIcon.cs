namespace backend.Models
{
    public class ImageIcon
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public int? Levels { get; set; }

        public string? Description { get; set; }

        public string? Image {  get; set; }

        public bool? Is_Active { get; set; }

        public bool? Is_Delete { get; set; }

        public DateTime? Created_at { get; set; }

        public DateTime? Updated_at { get; set; }

        public int? Created_by { get; set; }

        public int? Updated_by { get; set; }
    }
}
