using System.Collections.Generic;
using System.Threading.Tasks;
using sheeple.Shared.DTO.Helper;
using sheeple.Shared.DTO.Helper;
using sheeple.Shared.DTO.Person;

namespace sheeple.Core.Services.HelperService
{
    public interface IHelperService
    {
        Task<IEnumerable<DropdownCountryDTO>> ListCountriesAsync();
        Task<IEnumerable<DropdownGenderDTO>> ListGendersAsync();
    }
}