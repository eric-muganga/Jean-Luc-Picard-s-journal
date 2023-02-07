List<string> content = new List<string>();
bool startWriting = false;

Console.WriteLine("Enter 'start' to start writing in the journal.");
Console.WriteLine("Enter 'stop' to stop writing in the journal.");

while (true)
{
    string line = Console.ReadLine().Trim();
    if (line == "start")
    {
        startWriting = true;
    }
    else if (line == "stop")
    {
        startWriting = false;
        break;
    }
    else if (startWriting)
    {
        content.Add(line);
    }
}

string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
//string fileName = @"C:\Users\ericm\source\repos\Jean - Luc Picard’s journal" + currentDate + ".txt";

string header = "Captain's log\nStardate " + currentDate + "\n";
string body = string.Join("\n", content.ToArray());
string footer = "\nJean-Luc Picard";

File.WriteAllText(@"C:\Users\ericm\source\repos\Jean - Luc Picard’s journal" + currentDate + ".txt", header + body + footer);

