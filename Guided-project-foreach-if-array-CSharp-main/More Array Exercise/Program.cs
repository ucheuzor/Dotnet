//This C# Program is written to reverse each character in a sentence.

string pangram = "The quick brown fox jumps over the lazy dog";
string[] splitedSentence = pangram.Split(' ');
string[] reversedSentence = new string[splitedSentence.Length];

for (int i = 0; i < splitedSentence.Length; i++)
{
    char[] charIndividualSentence = splitedSentence[i].ToCharArray();
    Array.Reverse(charIndividualSentence);
    string ReversedSentenceString = new string(charIndividualSentence);

    reversedSentence[i] = ReversedSentenceString;
}

//Join reversed Sentence
string joinReversedSentence = string.Join(' ', reversedSentence);

Console.WriteLine($"Original Sentence: {pangram}");
Console.WriteLine("");

Console.WriteLine($"Reversed Sentence: {joinReversedSentence}");
