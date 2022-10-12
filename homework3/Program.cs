Console.Write("enter x:");

        double x = Convert.ToDouble(Console.ReadLine());
        double resultequations, resultsin,y;
                resultequations = -6 * x * x * x + 5 * x * x - 10 * x + 15;

Console.WriteLine($"-6x^3+5x^2-10x+15={resultequations}");

                resultsin = Math.Abs(x) * Math.Sin(x);

Console.WriteLine($"abs(x)sin(x)={resultsin}");

    y = 2 * Math.PI * x;

Console.WriteLine($"2pix={y}");

Console.WriteLine($"max(x, y)={Math.Max(x, y)}");
        var today = DateTime.Today;
        var newYear = new DateTime(today.Year + 0, 12, 31);
        var daysfornewyear = (newYear - today).TotalDays;

Console.WriteLine("{0} days before new year.", daysfornewyear);