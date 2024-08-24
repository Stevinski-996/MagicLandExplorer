namespace MagicLandExplorer {

public class SortByName {
public static void NameSort (List<Category> categories) {
var sortedDestinations = categories
    .SelectMany(c => c.Destinations)
    .OrderBy(d => d.Name);

Console.WriteLine("Destinations sorted alphabetically:");
foreach (var destination in sortedDestinations)
{
    Console.WriteLine(destination.Name);
}
}}}