using sheeple.Shared.DTO.Helper;

namespace sheeple.Models
{
    public class HelpersViewModel
    {
        public IEnumerable<DropdownCountryDTO>? Countries { get; set; }
        public IEnumerable<DropdownGenderDTO>? Genders { get; set; }
    }
}