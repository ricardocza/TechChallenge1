namespace TechChallenge1.Core.Models
{
    public class Contact : EntityBase
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}