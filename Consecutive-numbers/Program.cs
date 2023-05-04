Console.Write("Enter a few numbers separated by hyphen: ");
var input = Console.ReadLine();

var numbers = input.Split('-').Select(int.Parse).ToList();

var isConsecutive = true;
for (int i = 1; i < numbers.Count; i++)
{
    if (numbers[i] != numbers[i - 1] + 1)
    {
        isConsecutive = false;
        break;
    }
}

var message = isConsecutive ? "Consecutive" : "Not Consecutive";
Console.WriteLine(message);
