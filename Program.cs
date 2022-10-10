string[] StringArray = {"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Rus", "Denmark", "Kazan"};

Console.Write("[");
Console.Write(PrintText(FindStringArray(StringArray)));
Console.Write("]");

string [] FindStringArray(string [] array)
{

  return result;
}

string PrintText(string [] array)
{
  string result = String.Empty;
  if(array == null){return result;}
  for (int i=0; i<array.Length; i++)
  {
    if(i == array.Length-1) {result= result + $"{array[i]}";}
    else {result= result + $"{array[i]}"+ ", ";}
  }
  return result;
}