// See https://aka.ms/new-console-template for more information
using LinqRefactorDemo;

string[] csvlines = File.ReadAllLines("rooms.csv");
var rooms = new List<Room>();
foreach(string line in csvlines)
{
    string[] parts = line.Split(',');
    string name = parts[0];
    string capacity = parts[1];
    string faculty = parts[2];
    string needsKey = parts[3];
    string hasProjector = parts[4];

    var room = new Room();
    room.Name = name;
    room.Capacity = int.Parse(capacity);
    room.Faculty = faculty;
    room.NeedsKey = needsKey.Contains("kulcs");
    room.HasProjector = hasProjector.Contains("proje");
    rooms.Add(room);

    Console.WriteLine($"Room {room.Name} has capacity {room.Capacity}. Faculty {room.Faculty}, needskey {room.NeedsKey}, hasProjector {room.HasProjector}");
}

List<string> faculties = new List<string>();
foreach(Room room in rooms)
{
    if(!faculties.Contains(room.Faculty))
    {
        faculties.Add(room.Faculty);
    }
}

// Total capacity of each faculty with rooms having projector
var facultiesWithCapacity = new List<FacultyWithCapacity>();
foreach(string faculty in faculties)
{
    int sumCapacityOfFaculty = 0;
    foreach (Room room in rooms)
    {
        if(room.Faculty == faculty && room.HasProjector)
        {
            sumCapacityOfFaculty += room.Capacity;
        }
    }
    facultiesWithCapacity.Add(new FacultyWithCapacity
        { Name = faculty, Capacity = sumCapacityOfFaculty });
}

facultiesWithCapacity.Sort(new FacultyCapacityComparer());

foreach(var faculty in facultiesWithCapacity)
{
    Console.WriteLine($"Faculty {faculty.Name} has capacity (with projector) {faculty.Capacity}");
}

