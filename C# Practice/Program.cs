
string logLine = "[ERROR]: \t Corrupt disk\t \t \r\n";

//output: Operation completed (info)

int checkOpeningBracket = logLine.IndexOf('[');
int checkClosingBracket = logLine.IndexOf("]:");
string specialCharacters = "\t \t \r\n";
logLine = logLine.Remove(logLine.IndexOf(specialCharacters), specialCharacters.Length);

string retrievedLogSection = logLine.Substring(checkOpeningBracket + 1, checkClosingBracket - checkOpeningBracket - 1);
string retrieveSecondSection = logLine.Substring(checkClosingBracket + 2);

Console.WriteLine($"{retrieveSecondSection} ({retrievedLogSection.ToLower()})".Trim());


/*
string specialCharacters = "\r\n";

int closingParenthesisCheck = logList.IndexOf("]");
int colonCheck = logList.IndexOf(":");

if (closingParenthesisCheck != -1 && colonCheck != -1)
{
    string matchingItems = logList.Substring(colonCheck + 1).Trim();
    if (matchingItems.Contains(specialCharacters))
    {
        matchingItems = matchingItems.Remove(matchingItems.IndexOf(specialCharacters), specialCharacters.Length);
    }
    Console.WriteLine(matchingItems);

}
*/