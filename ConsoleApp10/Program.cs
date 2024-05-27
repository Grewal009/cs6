namespace ConsoleApp10;

class Program
{
    static void Main(string[] args)
    {
        PrintDayOfWeek();
    }
    
    
    //Ha en variabel med datatypen int og gi den en value med et tall mellom1 og 7. 
    // Bruk en switch for å finne ut hvilken dag i uken det tallet er, og print ut dagen med Console.WriteLine();
    public static void PrintDayOfWeek()
    {
        int num = 7;
        switch (num)
        {
            case 1:
            {
                Console.WriteLine("Monday");
                break;
            }
            case 2:
            {
                Console.WriteLine("Tuesday");
                break;
            }
            case 3:
            {
                Console.WriteLine("Wednesday");
                break;
            }
            case 4:
            {
                Console.WriteLine("Thursday");
                break;
            }
            case 5:
            {
                Console.WriteLine("Friday");
                break;
            }
            case 6:
            {
                Console.WriteLine("Saturday");
                break;
            }
            case 7:
            {
                Console.WriteLine("Sunday");
                break;
            }
            default:
            {
                Console.WriteLine("Wrong input");
                break;
            }
        }
    }
}