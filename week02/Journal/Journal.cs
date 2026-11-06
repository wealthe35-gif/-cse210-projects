using System.IO;
using System.Collections.Generic;

public class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public void AddEntry(Entry entry)
  {
    _entries.Add(entry);
  }
  public void DisplayEntries()
  {
    if (_entries.Count == 0)
    {
      Console.WriteLine("Your journal is empty.");
      return;
    }

    foreach (Entry entry in _entries)
    {
      entry.Display();
    }
  }
  
  public void SaveToFile(string filename)
  {
    string journalText = "";

    foreach (Entry entry in _entries)
    {
      journalText += $"{entry._date}|{entry._prompt}|{entry._response}\n";
    }

    File.WriteAllText(filename, journalText);
  }
  public void LoadFromFile(string filename)
  {
    if (!File.Exists(filename))
    {
      Console.WriteLine("File not found.");
      return;
    }
    _entries.Clear();

    string[] lines = File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      string[] parts = line.Split('|');

      if (parts.Length == 3)
      {
        Entry entry = new Entry(parts[0], parts[1], parts[2]);
        _entries.Add(entry);
      }
    }

    Console.WriteLine("Journal loaded successfully!");
  }
  }
