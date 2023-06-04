namespace BackEnd.Relations.Entities
{
    public class Chef
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Profession> Profession { get; set; }
        public List<Testimonial> Testimonials { get; set;}
        public List<ChefSocialMedia> ChefSocialMedias { get; set;}
    }
}
