namespace MagicLandExplorer {

public class Top3Duration {
public static void TopDurations (List<Category> categories) {
var topThreeLongest = categories
    .SelectMany(c => c.Destinations)
    .OrderByDescending(d => d.Duration)
    .Take(3);

Console.WriteLine("Top 3 longest-duration destinations:");
foreach (var destination in topThreeLongest)
{
    Console.WriteLine($"{destination.Name} - {destination.Duration} minutes");
}
}}}