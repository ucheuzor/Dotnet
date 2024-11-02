/*Given a MultiDimenstion array of emails, I wrote a method to retrieve the first 2 letter of the firstname, combine it with the lastname,
 then form an email using a the company domain
 */


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

for (int i = 0; i < corporate.GetLength(0); i++)
{
    GenerateEmailAddress(corporate[i, 0], corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    GenerateEmailAddress(corporate[i, 0], corporate[i, 1], externalDomain);
}

//Define the method to generate the email address
void GenerateEmailAddress(string firstname, string lastname, string domain = "contoso.com")
{
    string extractedFirstName = firstname.ToLower().Substring(0, 2);
    string lastName = lastname.ToLower();
    string emailAddress = $"{extractedFirstName}{lastName}@{domain}";

    Console.WriteLine(emailAddress);
}


/*
void GenerateEmailAddress(string[,] corporateEmails, string[,] externalEmails, string internalDomain, string externalDomain = "microsoft")
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

*/
