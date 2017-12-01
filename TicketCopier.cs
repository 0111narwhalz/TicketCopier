using System;
using System.IO;

class TicketCopier
{
  public static void Main()
  {
    string inputFile = "ticketlist.csv";
    string outputFile = "copiedTickets.csv";
    string[] fileContents = File.ReadAllLines(inputFile);
    File.Create(outputFile).Dispose();
    for(int i = 1; i < fileContents.Length; i++)
    {
      for(int j = 0; j < int.Parse(fileContents[i].Split(',')[4]); j++)
      {
        File.AppendAllText(outputFile, fileContents[i] + '\n');
      }
    }
  }
}
