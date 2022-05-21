﻿using System.Collections.Generic;
using System.Threading.Tasks;
using sheeple.Shared.DTO.Person;

namespace sheeple.Core.Services.PersonService
{
    public interface IPersonService
    {
        Task<IEnumerable<PersonDTO>> GetAllAsync();
        Task<PersonDTO> GetAsync(int id);
        Task<PersonUpdateDTO> UpdateAsync(int id, PersonDTO updateData);
        Task<PersonDTO> CreateAsync(PersonDTO createData);
        Task<PersonDTO> DeleteAsync(int id);
    }
}