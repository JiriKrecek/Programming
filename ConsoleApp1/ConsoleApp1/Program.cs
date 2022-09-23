string[] text = new string[] {};

string filter = Console.ReadLine();


List<string> filteredWords = new List<string>();

for (int i = 0; i < text.Length; i++)
{
    string word = text[i];
    char firstChar = word[0];

    if (filter[0] == firstChar)
    {
        filteredWords.Add(word);
    }
}