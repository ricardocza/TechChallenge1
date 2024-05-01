
using TechChallenge1.Core.Models;

namespace TechChallenge1.Core.DTO
{
    public class ContactDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string State { get; set; }

        public static ContactDto From(Contact contact)
        {
            return new ContactDto()
            {
                Id = contact.Id,
                Name = contact.Name,
                Email = contact.Email,
                Phone = contact.Phone,
                State = contact.State.Name
            };
        }

        public static List<ContactDto> FromRange(IQueryable<Contact> contacts)
        {
            List<ContactDto> result = new List<ContactDto>();

            foreach (var contact in contacts)
            {
                result.Add(From(contact));
            }

            return result;
        }
    }
}