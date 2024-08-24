namespace MagicLandExplorer {

public class LongestDuration {
public static void LongestDure (List<Category> categories) {
var longestDurationDestination = categories
    .SelectMany(c => c.Destinations)
    .OrderByDescending(d => d.Duration)
    .FirstOrDefault();

Console.WriteLine($"Destination with the longest duration: {longestDurationDestination?.Name} ({longestDurationDestination?.Duration} minutes)");
}}}