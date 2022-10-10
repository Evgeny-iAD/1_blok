string[] StringArray = {"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Rus", "Denmark", "Kazan"};

Console.Write("[");
Console.Write(PrintText(FindStringArray(StringArray)));
Console.Write("]");

string [] FindStringArray(string [] array)
{
  int n = 0;
  for (int i = 0; i<array.Length; i++)
  {
      if (array[i].Length <= 3) { n++;}
  }

  string [] result = new string [n];
  int j = 0;

  for (int i = 0; i<array.Length; i++)
  {
      if (array[i].Length <= 3)
      {
       result[j] = array[i];
       j++;
      }
  }
  return result;
}

string PrintText(string [] array)
{

  return "-1";
}