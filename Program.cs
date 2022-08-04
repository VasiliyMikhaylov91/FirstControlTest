string [] startArray = {"Hello", "2", "world", ":-)"};

string endString = String.Empty;

int lengthLimit = 3;

for (int i = 0; i < startArray.Length; i++)
{
    if (startArray[i].Length <= lengthLimit) endString += startArray[i] + ";";
}

string[] endArray = endString.Split(";");

Console.WriteLine($"[{String.Join(", ", endArray)}]");