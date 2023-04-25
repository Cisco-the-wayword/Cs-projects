using System;

class Date
{
    private int day;
    private int month;
    private int year;
    private string separator;

    public Date(string dayStr, string monthStr, string yearStr, string separator)
    {
        this.separator = separator;

        if (separator != "-" && separator != "/")
        {
            Console.WriteLine("Invalid separator. Please use '-' or '/'");
            return;
        }

        if (!int.TryParse(dayStr, out day))
        {
            day = GetDayFromString(dayStr);
        }

        if (!int.TryParse(monthStr, out month))
        {
            month = GetMonthFromString(monthStr);
        }

        int.TryParse(yearStr, out year);
    }

    public string GetDateFormat()
    {
        return string.Format("{0:00}{1}{2:00}{3}{4:0000}", day, separator, month, separator, year);
    }

    private int GetDayFromString(string dayStr)
    {
        switch (dayStr.ToLower())
        {
            case "one":
                return 1;
            case "two":
                return 2;
            case "three":
                return 3;
            case "four":
                return 4;
            case "five":
                return 5;
            case "six":
                return 6;
            case "seven":
                return 7;
            case "eight":
                return 8;
            case "nine":
                return 9;
            case "ten":
                return 10;
            case "eleven":
                return 11;
            case "twelve":
                return 12;
            case "thirteen":
                return 13;
            case "fourteen":
                return 14;
            case "fifteen":
                return 15;
            case "sixteen":
                return 16;
            case "seventeen":
                return 17;
            case "eighteen":
                return 18;
            case "nineteen":
                return 19;
            case "twenty":
                return 20;
            case "twenty-one":
                return 21;
            case "twenty-two":
                return 22;
            case "twenty-three":
                return 23;
            case "twenty-four":
                return 24;
            case "twenty-five":
                return 25;
            case "twenty-six":
                return 26;
            case "twenty-seven":
                return 27;
            case "twenty-eight":
                return 28;
            case "twenty-nine":
                return 29;
            case "thirty":
                return 30;
            case "thirty-one":
                return 31;
            default:
                throw new ArgumentException("Invalid day string");
        }
    }

    private int GetMonthFromString(string monthStr)
    {
        switch (monthStr.ToLower())
        {
            case "january":
                return 1;
            case "february":
                return 2;
            case "march":
                return 3;
            case "april":
                return 4;
            case "may":
                return 5;
            case "june":
                return 6;
            case "july":
                return 7;
            case "august":
                return 8;
            case "september":
                return 9;
            case "october":
                return 10;
            case "november":
                return 11;
            case "december":
                return 12;

            default:
                throw new ArgumentException("Invalid month string");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please note that when you want to input compound numbers, you should use an hyphen \n E.G: twenty-six");
        Console.WriteLine("Please enter the day:");
        var dayStr = Console.ReadLine();

        Console.WriteLine("Please enter the month:");
        var monthStr = Console.ReadLine();

        Console.WriteLine("Please enter the year:");
        var yearStr = Console.ReadLine();

        Console.WriteLine("Please enter the separator (- or /):");
        var separator = Console.ReadLine();

        // create a Date object
        var d = new Date(dayStr, monthStr, yearStr, separator);

        // get the date format
        var dateFormat = d.GetDateFormat();
        Console.WriteLine(dateFormat);

        // wait for user input to close the console
        Console.ReadLine();
    }
}
