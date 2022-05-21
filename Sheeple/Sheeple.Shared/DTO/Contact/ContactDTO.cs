using System;
using sheeple.Shared.DTO.Person;

namespace sheeple.Shared.DTO.Contact
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int PersonId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public ContactDTO()
        {
            DateCreated = DateTime.Now;
        }
    }
}