using System;
using System.ComponentModel.DataAnnotations;

namespace sheeple.Data.Data.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
        public Avatar Avatar { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}