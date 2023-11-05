using System.Globalization;

DateTime today = DateTime.Now;

/**A better way is by using UtcNow*/
DateTime todayCorrect = DateTime.UtcNow; //sets time bases on this computer

DateTime birthday = DateTime.Parse("6/15/1998");

DateTime birthday2 = DateTime.ParseExact("6/11/1998", "d/M/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(today);
Console.WriteLine(todayCorrect);

Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"));
Console.WriteLine(today.ToString("M"));
Console.WriteLine(birthday.ToString());
Console.WriteLine(birthday2.ToString());

