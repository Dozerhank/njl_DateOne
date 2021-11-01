using System;

class Date
{
    //Class Attributes
    private int day, month, year;

    //Attribute Methods
    public int Day
    {
        get
        {
            return day;
        }
        set
        {
            if (value > 31 || value < 1)
            {
                Console.WriteLine("Invalid day");
            }
            day = value;
        }
    }

    public int Month
    {
        get
        {
            return month;
        }
        set
        {
            if (value > 12 || value < 1)
            {
                Console.WriteLine("Invalid month");
            }
            month = value;
        }
    }

    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            if (Convert.ToString(value).Length != 4)
            {
                Console.WriteLine("Year must be 4 digits");
            }
            year = value;
        }
    }

    //Constructor Defaults
    public Date()
    {
        day = 6;
        month = 1;
        year = 2000;
    }

    //Constructor declaration with parameters (write only if Athene requires)
    public Date(int m, int d, int y)
    {
        this.Month = m;
        this.Day = d;
        this.Year = y;
    }

    //Method to display the date in US Format
    public string DisplayUSFormat()
    {
        if (this.Month <= 12 && this.Month >= 1)
        {
            if (this.Day <= 31 && this.Day >= 1)
            {
                if (Convert.ToString(this.Year).Length == 4)
                {
                    return this.Month.ToString("D2") + "/" + this.Day.ToString("D2") + "/" + this.Year;
                }
            }
        }
        return "Invalid date";
    }

    //Method to display the date in Intl Format
    public string DisplayIntlFormat()
    {
        if (this.Month <= 12 && this.Month >= 1)
        {
            if (this.Day <= 31 && this.Day >= 1)
            {
                if (Convert.ToString(this.Year).Length == 4)
                {
                    return this.Year + "-" + this.Month.ToString("D2") + "-" + this.Day.ToString("D2");
                }
            }
        }
        return "Invalid date";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Date b = new Date();
        b.Day = 1;
        b.Year = 1996;
        b.Month = 12;

        Console.WriteLine(b.Day);


        Date c = new Date();
        c.Day = 7;
        c.Year = 1980;
        c.Month = 8;
        Console.WriteLine(c.DisplayIntlFormat());
        Console.WriteLine(c.DisplayUSFormat());

        Date d = new Date(12, 30, 2000);
        d.Day = 32;
        Console.WriteLine(d.DisplayUSFormat());
        d.Month = 13;
        Console.WriteLine(d.DisplayUSFormat());
        d.Year = 123;
        Console.WriteLine(d.DisplayUSFormat());
    }
}