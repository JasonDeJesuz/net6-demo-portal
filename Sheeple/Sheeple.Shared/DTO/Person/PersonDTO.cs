using System;
using sheeple.Shared.DTO.Address;
using sheeple.Shared.DTO.Avatar;
using sheeple.Shared.DTO.Contact;

namespace sheeple.Shared.DTO.Person
{
    public class PersonDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public AddressDTO? Address { get; set; }
        public ContactDTO? Contact { get; set; }
        public AvatarDTO? Avatar { get; set; }
        // public PersonDTO()
        // {
        //     this.Address = new AddressDTO();
        //     this.Contact = new ContactDTO();
        //     this.ProfilePicture = new ProfilePictureDTO();
        // }
        public PersonDTO()
        {
            DateCreated = DateTime.Now;
        }
    }
}