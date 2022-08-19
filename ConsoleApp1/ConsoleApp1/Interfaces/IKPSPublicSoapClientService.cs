using ConsoleApp1.Models;

namespace ConsoleApp1.Interfaces;

public interface IKPSPublicSoapClientService
{
    bool CheckPerson(Person person);
}