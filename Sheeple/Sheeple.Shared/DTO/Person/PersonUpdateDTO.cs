using System;
namespace sheeple.Shared.DTO.Person
{
	public class PersonUpdateDTO
	{
		public PersonDTO OriginalData { get; set; }
		public PersonDTO NewData { get; set; }
		public PersonUpdateDTO()
		{
			this.OriginalData = new PersonDTO();
			this.NewData = new PersonDTO();
		}
	}
}

