// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

IKPSPublicSoapClientService clientService = new KPSPublicSoapClientService();
var person = new Person();

Console.WriteLine("Tc Kimlik Numarası Giriniz : ");
var idStr = Console.ReadLine();
while (idStr.Length == 0)
{
    Console.WriteLine("Tc Kimlik Alanı Boş Bırakılmamalı, tekrar giriniz : ");
    idStr = Console.ReadLine();
}

Console.WriteLine("Ad Giriniz : ");
var firstName = Console.ReadLine();
while (firstName.Length == 0)
{
    Console.WriteLine("Ad Alanı Boş Bırakılmamalı, tekrar giriniz : ");
    firstName = Console.ReadLine();
}

Console.WriteLine("Soyad Giriniz : ");
var lastName = Console.ReadLine();
while (lastName.Length == 0)
{
    Console.WriteLine("Soyad Alanı Boş Bırakılmamalı, tekrar giriniz : ");
    lastName = Console.ReadLine();
}

Console.WriteLine("Doğum Yılı Giriniz : ");
var birthday = Console.ReadLine();
while (birthday.Length == 0)
{
    Console.WriteLine("Doğum Yılı Alanı Boş Bırakılmamalı, tekrar giriniz : ");
    birthday = Console.ReadLine();
}

person.Id = long.Parse(idStr);
person.FirstName = firstName;
person.LastName = lastName;
person.Birthday = int.Parse(birthday);

var infomationCheckResult = clientService.CheckPerson(person);

Console.WriteLine(infomationCheckResult);
