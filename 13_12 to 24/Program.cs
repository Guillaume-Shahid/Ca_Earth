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
            if((arg[0] > '1' && arg[1] > '2'))
            {
                return false;
            }
            if (char.IsDigit(arg[0]) &&
                 arg[0] <= '1' &&
                 char.IsDigit(arg[1]) &&
                 arg[2] == ':' &&
                 char.IsDigit(arg[3]) &&
                 arg[3] <= '5' &&
                 char.IsDigit(arg[4]) &&
                 (arg[5].ToString().ToUpper() == "P" || arg[5].ToString().ToUpper() == "A") &&
                 arg[6].ToString().ToUpper() == "M")
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

    private static bool HourContainDoubleZero(string hour)
    {
        if (hour[0] == '0' && hour[1] == '0')
        {
            return true;
        }

        return false;
    }

    private static string DisplayHourFrom12To24(string hour, string minutes)
    {
        string minutesWithoutAmOrPm = minutes.Remove(2, 2);
        
        if (minutes.ToUpper().Contains("AM"))
        {
            if (hour[0] == '1' && hour[1] == '2')
            {
                return $"00:{minutesWithoutAmOrPm}";
            }
            return $"{hour}:{minutesWithoutAmOrPm}";
        }
        else
        {
            if (hour[0] == '1' && hour[1] == '2')
            {
                return $"12:{minutesWithoutAmOrPm}";
            }
            return $"{(Int32.Parse(hour) - 12).ToString()}:{minutesWithoutAmOrPm}";
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

                if (!HourContainDoubleZero(hour))
                {
                    Console.WriteLine(DisplayHourFrom12To24(hour, minutes));

                }
                else
                {
                    Console.WriteLine("Tu dois me donner une heure au format 12:45PM par exemple.");
                }
            }
            else
            {
                Console.WriteLine("Tu dois me donner une heure au format 12:45PM par exemple.");
            }
        }
        else
        {
            Console.WriteLine("Tu dois rentrer un unique argument!");
        }
    }
}