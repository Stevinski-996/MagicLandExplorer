namespace MagicLandExplorer {

public class FilterDestinations {
    public static void SortedDestinations (List<Category> categories) {
var shortDestinations = categories
    .SelectMany(c => c.Destinations)
    .Where(d => d.Duration < 100)
    .Select(d => d.Name);

Console.WriteLine("Destinations with duration less than 100 minutes:");
foreach (var name in shortDestinations)
{
    Console.WriteLine(name);
}}
}}