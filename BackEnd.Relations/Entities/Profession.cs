namespace BackEnd.Relations.Entities

{
    public class Profession
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public Chef Chef { get; set; }
        public int ChefId { get; set; }
    }
}
