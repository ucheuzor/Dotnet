
string logList = "[INFO]: Operation completed";
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