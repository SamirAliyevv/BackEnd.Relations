namespace BackEnd.Relations.Entities
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Image { get; set; }
       public string FirstName { get; set; }

        public string LastName { get; set; }
        public string About { get; set; }

        public int ChefId { get; set; } 
        public Chef Chef { get; set; }
    }
}
