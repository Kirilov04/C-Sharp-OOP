using System.ComponentModel.Design;
using Telephony.Models;
using Telephony.Models.Interfaces;

public class StartUp
{
    static void Main(string[] args)
    {
        var phones = ReadInput();
        var urls = ReadInput();

        CallAllThePhones(phones);

        foreach (var url in urls) 
        {

            if (IsUrlValid(url))
            {
                SmartPhone smartPhone = new();
                smartPhone.Browse(url);
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }
    }

    private static bool IsUrlValid(string url)
    {
        return !url.Any(char.IsDigit);
    }
    

    private static void CallAllThePhones(string[] phones)
    {
        foreach (var phoneNumber in phones)
        {
            ICaller phone;

            if (IsValidPhoneNumber(phoneNumber))
            {
                switch (phoneNumber.Length)
                {
                    case 7:
                        phone = new StationaryPhone();
                        break;
                    default:
                        phone = new SmartPhone();
                        break;
                }
                phone.Call(phoneNumber);
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }

    private static bool IsValidPhoneNumber(string phoneNumber)
    {
        return phoneNumber.All(char.IsDigit);
    }

    private static string[] ReadInput()
    {
        return Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    }
}
