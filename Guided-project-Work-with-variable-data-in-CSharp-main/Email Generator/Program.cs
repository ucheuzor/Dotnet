
string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
string internalDomain = "contoso.com";

GenerateInternalEmailAddress(corporate, external, internalDomain, externalDomain);


void GenerateInternalEmailAddress(string[,] corporateEmails, string[,] externalEmails, string internalDomain, string externalDomain = "microsoft")
{

    for (int i = 0; i < corporateEmails.GetLength(0); i++)
    {
        string extractedFirstName = corporateEmails[i, 0].ToLower().Substring(0, 2);
        string lasttName = corporateEmails[i, 1].ToLower();
        string emailAddress = $"{extractedFirstName}{lasttName}@{internalDomain}";

        Console.WriteLine(emailAddress);
    }

    for (int i = 0; i < externalEmails.GetLength(0); i++)
    {
        // display external email addresses
        string extractedFirstName = externalEmails[i, 0].ToLower().Substring(0, 2);
        string lasttName = externalEmails[i, 1].ToLower();
        string emailAddress = $"{extractedFirstName}{lasttName}@{externalDomain}";

        Console.WriteLine(emailAddress);
    }
}
