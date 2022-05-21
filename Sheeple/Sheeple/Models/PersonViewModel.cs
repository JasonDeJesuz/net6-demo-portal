using sheeple.Shared.DTO.Person;

namespace sheeple.Models
{
    public class PersonViewModel : HelpersViewModel
    {
        public string? ActionType { get; set; }
        public int? Id { get; set; }
        public PersonDTO? Person { get; set; }
    }
}
