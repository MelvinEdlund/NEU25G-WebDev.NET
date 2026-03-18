using AutoMapper;
using DemoWebApi_automapper.Data.DTO;
using DemoWebApi_automapper.Data.Entities;

namespace DemoWebApi_automapper.Data.Profiles;

public class PersonProfile: Profile
{

    public PersonProfile()
    {
        // Destination här är PersonDTO och origin är Person
        // dvs vi mappar från Person till PersonDTO

        CreateMap<Person, PersonDTO>()
            .ForMember(destination => destination.Id, opt => opt.MapFrom(origin => origin.PersonID))
            .ForMember(destination => destination.FullName, opt => opt.MapFrom(origin => origin.Name))
            .ForMember(destination => destination.Mail, opt => opt.MapFrom(origin => origin.Email));

    }

}
