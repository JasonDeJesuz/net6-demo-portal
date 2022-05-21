using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using sheeple.Data.Context;
using sheeple.Shared.DTO.Helper;
using sheeple.Shared.DTO.Person;
using Microsoft.EntityFrameworkCore;

namespace sheeple.Core.Services.HelperService
{
    public class HelperService : IHelperService
    {
        #region Members
        private readonly sheepleContext _context;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public HelperService(sheepleContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        #endregion
        public async Task<IEnumerable<DropdownCountryDTO>> ListCountriesAsync()
        {
            try {
                var countries = await _context.DropdownCountries.Select(x => _mapper.Map<DropdownCountryDTO>(x)).ToListAsync();

                return countries;
            } catch(Exception ex) {
                throw;
            }
        }

        public async Task<IEnumerable<DropdownGenderDTO>> ListGendersAsync()
        {
            try {
                var genders = await _context.DropdownGenders.Select(x => _mapper.Map<DropdownGenderDTO>(x)).ToListAsync();

                return genders;
            } catch(Exception ex) {
                throw;
            }
        }
    }
}