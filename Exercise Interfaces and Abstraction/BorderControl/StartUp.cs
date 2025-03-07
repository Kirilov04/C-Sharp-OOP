using BorderControl.Models;
using System.Threading.Channels;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Models.BorderControl borderControl = new();

            string input;
            while ((input = Console.ReadLine()) != "End") 
            {
                string[] tokens = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 2)
                {
                    Robot robot = new(tokens[1], tokens[0]);
                    borderControl.AddEntityForBCheck(robot);
                }
                else
                {
                    Citizen citizen = new Citizen (tokens[2], int.Parse(tokens[1]), tokens[1]);
                    borderControl.AddEntityForBCheck(citizen);
                }
            }
            string fakeIdEnd = Console.ReadLine();
            var detained = borderControl.EntToBeChecked.Where(e => e.Id.EndsWith(fakeIdEnd));

            foreach (var baseEntity in detained)
            {
                Console.WriteLine(baseEntity.Id);
            }
    }
        }
    
}
/*
                         Input
Peter 22 9010101122
MK-13 558833251
MK-12 33283122
End
122

Teo 31 7801211340
Peter 29 8007181534
IV-228 999999
Sam 54 3401018380
KKK-666 80808080
 */
