using ConsoleApp1.Models;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces;

internal class KPSPublicSoapClientService : IKPSPublicSoapClientService
{
    protected KPSPublicSoapClient client;
    public KPSPublicSoapClientService()
    {
        client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
    }

    public bool CheckPerson(Person person)
    {
        return client.TCKimlikNoDogrulaAsync(person.Id, person.FirstName, person.LastName, person.Birthday).Result.Body.TCKimlikNoDogrulaResult;
    }
}
