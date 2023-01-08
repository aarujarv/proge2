string path = @"C:\Users\aaruj\Google Drive\!KOOL\!Kool\Programmeerimise alused\data";
string fileName = "chucky.txt";
string[] lines = File.ReadAllLines(Path.Combine(path,fileName));

ShowFileContent(lines);

static Array ShowFileContent(string[] fileContentArray)
{
    int i = ;
    foreach (string line in fileContentArray)
    {
        Console.WriteLine($"{i}. {...}");
        i++;
    }
}