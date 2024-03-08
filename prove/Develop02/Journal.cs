using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}~|~{entry._quote}~|~{entry._music}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        
        string[] lines = System.IO.File.ReadAllLines(file);
      
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            
            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
            string quote = parts[3];
            string music = parts[4];

            Entry entryFile = new Entry();

            entryFile._date = date;
            entryFile._promptText = prompt;
            entryFile._entryText = entry;
            entryFile._quote = quote;
            entryFile._music = music;
            _entries.Add(entryFile);
        }
    }   

}
