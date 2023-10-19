using LinqRefactorDemo;

var rooms =
    File.ReadAllLines("rooms.csv")
    .Select(csvline => csvline.Split(','))
    .Select(parts => new Room
    {
        Name = parts[0],
        Capacity = int.Parse(parts[1]),
        Faculty = parts[2],
        NeedsKey = parts[3].Contains("kulcs"),
        HasProjector = parts[4].Contains("proje")
    });

var facultiesWithCapacity = rooms
    .Where(room => room.HasProjector)
    .GroupBy(rooms => rooms.Faculty)
    .Select(group => (Name: group.Key, Capacity: group.Sum(room => room.Capacity)))
    .OrderBy(f => f.Capacity);

foreach(var faculty in facultiesWithCapacity)
{
    Console.WriteLine($"Faculty {faculty.Name} has capacity (with projector) {faculty.Capacity}");
}

// First, FirstOrDefault, Single, SingleOrDefault
var q1 = rooms.Where(r => r.Name.Contains("Q-I")).Single();
Console.WriteLine($"Q-I room: {q1.Name} {q1.Capacity} {q1.Faculty}");
