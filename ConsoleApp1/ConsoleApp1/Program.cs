// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

IKPSPublicSoapClientService clientService = new KPSPublicSoapClientService();
var person = new Person();
person.Id = 0000;
person.FirstName = "Hazar Fatih";
person.LastName = "Akman";
person.Birthday = 2000;

var test1 = clientService.CheckPerson(person);

Console.WriteLine(test1.ToString());


