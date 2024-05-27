namespace ConsoleApp10;

class Program
{
    static void Main(string[] args)
    {
        PrintDayOfWeek();
        PrintDayOfWeek2();
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
    //Ta utgangspunkt fra oppgave 1, men istedenfor å bruke en int med en fastsatt value, bruker du Console.ReadLine() for at
    //man kan skrive inn et tall i konsollen. Hvis man ikke får inn et tall, skal switch-en kjøre programmet på nytt. 
    
    public static void PrintDayOfWeek2()
    {
        Console.Write("Enter number from 1 to 7: ");
        var input = Console.ReadLine();
        int num = Convert.ToInt32(input);
        if (num >= 1 && num <= 7)
        {
             /*switch (num)
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
            }*/
             
             //switch using expression syntax
             string weekDay = num switch
             {
                 1 => "Monday",
                 2 => "Tuesday",
                 3 => "Wednesday",
                 4 => "Thursday",
                 5 => "Friday",
                 6 => "Saturday",
                 7 => "Sunday",
                 _ => "Input not valid",
             };
             Console.WriteLine($"{num} => {weekDay}");

        }
        else
        {
            Console.WriteLine("Try again!");
            PrintDayOfWeek2();
        }
    }
}