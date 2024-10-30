
string message = "What is the value <span>between the tags</span>";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;

int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length));

/*
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(') + 1;
int closingPosition = message.IndexOf(')');

int length = closingPosition - openingPosition;

string result = message.Substring(openingPosition, length);

Console.WriteLine(result);

*/