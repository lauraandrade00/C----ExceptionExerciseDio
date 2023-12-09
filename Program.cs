
try {
  string[] lines = File.ReadAllLines("Archives/readingFile.txt");

  foreach(string line in lines)
  {
    Console.WriteLine(line);
  }
} catch(FileNotFoundException ex)
{
  Console.WriteLine($"An error occurred while reading the file. File not found. {ex.Message}");
} catch(DirectoryNotFoundException ex)
{
  Console.WriteLine($"An error occurred while reading the file. Folder path not found."
   + ex.Message);
} catch(Exception ex)
{
  Console.WriteLine($"A generic exception occurred. {ex.Message}");
}
finally
{
  Console.WriteLine("Got this far.");
}
