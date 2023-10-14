try
{
    Console.Write("Enter Birth year: "); int year = int.Parse(Console.ReadLine());
    Console.Write("Enter Birth month: "); int month = int.Parse(Console.ReadLine());
    Console.Write("Enter Birth day: "); int day = int.Parse(Console.ReadLine());

    Console.WriteLine("\nWhat you wanna calculate?\n1.Years\n2.Months\n3.Days\n4.Hours\n5.Seconds\n");
EnteringKey:
    Console.Write("Enter Key: ");
    ConsoleKeyInfo key = Console.ReadKey(); Console.WriteLine();

    DateTime birthdate = new DateTime(year, month, day);
    DateTime currentDate = DateTime.Now;
    TimeSpan livingDays = currentDate - birthdate;

    switch (key.KeyChar)
    {
        case '1': Console.WriteLine("Years lived: " + (currentDate.Year - year)); break;
        case '2':
            int months = (currentDate.Year - year) * 12 + currentDate.Month - birthdate.Month;
            if (currentDate.Day < birthdate.Day) months--;
            Console.WriteLine("Months lived: " + months); break;
        case '3': Console.WriteLine("Days survived: " + (int)livingDays.TotalDays); break;
        case '4': Console.WriteLine("Hours lived: " + (int)livingDays.TotalHours); break;
        case '5': Console.WriteLine("Seconds living: " + (int)livingDays.TotalSeconds); break;
        default: Console.WriteLine("Enter valid key!"); goto EnteringKey;
    }
}
catch { Console.WriteLine("\nYear/Month/Day is not entered correctly!"); }