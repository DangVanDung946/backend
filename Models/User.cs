namespace backend.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string? First_Name { get; set; }

        public string? Last_Name { get; set; }

        public string? Avatar {  get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Password {  get; set; }

        public string? Salt { get; set; }

        public bool? Is_Admin { get; set; }

        public DateTime? Last_Login { get; set; }

        public bool? Is_Active { get; set; }

        public bool? Is_Delete { get; set; }

        public DateTime? Created_at { get; set; }

        public DateTime? Updated_at { get; set; }
    }
}
