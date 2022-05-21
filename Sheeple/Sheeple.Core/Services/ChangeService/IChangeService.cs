using System;
using System.Threading.Tasks;
using sheeple.Shared.DTO.Change;
using sheeple.Shared.DTO.Person;
using sheeple.Shared.DTO.Variance;

namespace sheeple.Core.Services.ChangeService
{
    public interface IChangeService
    {
        public Task<List<VarianceDTO>> GetPersonChangesAsync(PersonDTO originalData, PersonDTO newData);
    }
}
