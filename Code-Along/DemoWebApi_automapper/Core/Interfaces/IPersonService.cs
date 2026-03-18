using DemoWebApi_automapper.Data.DTO;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApi_automapper.Core.Interfaces;

public interface IPersonService
{

    PersonDTO GetPerson(int id);



}
