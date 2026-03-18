using AutoMapper;
using DemoWebApi_automapper.Core.Interfaces;
using DemoWebApi_automapper.Data.DTO;
using DemoWebApi_automapper.Data.Interfaces;

namespace DemoWebApi_automapper.Core.Services;

public class PersonService : IPersonService
{
    private readonly IMapper _mapper;
    private readonly IPersonRepo _repo;

    public PersonService(IMapper mapper, IPersonRepo repo)
    {
        _mapper = mapper;
        _repo = repo;
    }

    public PersonDTO GetPerson(int id)
    {
        // Hämtar person från repot
        var person = _repo.GetPerson(id);

        // Mappar till det externa formatet innan det skickas vidare
        return _mapper.Map<PersonDTO>(person);

    }
}
