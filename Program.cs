string [] startArray = {"hello", "2", "world", ":-)"};

int lengthStringLimit = 3;

string endString = String.Empty;


for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= lengthStringLimit) endString += startArray[i] + ";";
}

string[] endArray = endString.Split(";");

Console.WriteLine($"[{String.Join(", ", endArray)}]");