using Humanizer;

Console.WriteLine(TimeSpan.FromMilliseconds(1299630020).Humanize(3));
Console.WriteLine(TimeSpan.FromMilliseconds(3603001).Humanize(3));
Console.WriteLine(TimeSpan.FromMilliseconds(8157019263).Humanize(3));

// 2 weeks, 1 day, 1 hour
// 1 hour, 3 seconds, 1 millisecond
// 13 weeks, 3 days, 9 hours