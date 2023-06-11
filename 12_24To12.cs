class Program
{
    private static bool CheckIfOneArgsExists(string[] args)
    {
        if(args.Length != 2)
        {
            return false;   
        }
        return true;
    }
    
    private static bool IsArgInDecentFormat(string arg)
    {
        try
        {
            if((arg[0] >= '2' && arg[1] >= '4'))
            {
                return false;
            }
            if ((char.IsDigit(arg[0]) &&
                 arg[0] <= '2' &&
                 char.IsDigit(arg[1]) &&
                 arg[2] == ':' &&
                 char.IsDigit(arg[3]) &&
                 arg[3] <= '5' && 
                 char.IsDigit(arg[4])) && 
                 arg.Length == 5 ||
                 (arg[0] >= '2' && 
                 arg[1] >= '4') )
            {
                return true;
            }

            return false;
        }
        catch
        {
            return false;
        }
    }

    private static string DisplayHourAmPmFormat(string hour, string minutes)
    {
        int hourInIntFormat = Int32.Parse(hour);

        if(hour == "00")
        {
            return $"12:{minutes}AM";
        }
        else if(hour == "12")
        {
            return $"12:{minutes}PM";
        }
        else if(hourInIntFormat < 12)
        {
             return $"{hour}:{minutes}AM";
        }
        else
        {
            int hourPm = hourInIntFormat - 12;
            int hourLength = hourPm.ToString().Length;

            return (hourLength < 2) ? $"0{hourPm}:{minutes}PM" : $"{hourPm}:{minutes}PM" ;
        }
    }

    private static void Main(string[] args)
    {
        if (CheckIfOneArgsExists(args))
        {
            string hourToConvert = args[1];

            if (IsArgInDecentFormat(hourToConvert))
            {
                string[] hourAndMinuteSplited =  hourToConvert.Split(':');
                
                string hour = hourAndMinuteSplited[0].ToString();
                string minutes = hourAndMinuteSplited[1].ToString();

                Console.WriteLine(DisplayHourAmPmFormat(hour, minutes));
            }
            else
            {
                Console.WriteLine("Tu dois me donner une heure au format HH:mm.");
            }
        }
        else
        {
            Console.WriteLine("Tu dois rentrer un unique argument!");
        }
    }
}