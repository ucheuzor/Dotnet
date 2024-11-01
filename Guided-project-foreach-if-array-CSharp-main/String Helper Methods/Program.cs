//C# code to extract specific text from sentence
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

string span = "<span>";
string div = "<div>";

// Your work here
int openingPosition = input.IndexOf(span) + span.Length;
int closingPosition = input.IndexOf("</span>");
int openingDivPosition = input.IndexOf(div) + div.Length;
int closingDivPosition = input.IndexOf("</div>");

int length = closingPosition - openingPosition;
int Divlength = closingDivPosition - openingDivPosition;

quantity = input.Substring(openingPosition, length);
output = input.Substring(openingDivPosition, Divlength);



Console.WriteLine(quantity);
Console.WriteLine(output);





/* 
//Remove Character from string
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

//More Examples with LastIndexOf

string message = "(What if) I am (only interested) in the last (set of parentheses)?";

while (true)
{
    int openingPosition = message.IndexOf('(');

    if (openingPosition == -1)
        break;

    openingPosition += 1;

    int closingPosition = message.IndexOf(')');

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:

    message = message.Substring(closingPosition + 1);
}

//More Examples with LastIndexOf
using System.ComponentModel.DataAnnotations;

string message = "(What if) I am (only interested) in the last (set of parentheses)?";

int openingPosition = message.LastIndexOf('(');
openingPosition += 1;

int closingPosition = message.LastIndexOf(')');

int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length));

---------------------------------------------------------------------------------------------
string message = "What is the value <span>between the tags</span>";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;

int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length));


string messageTest = "Find what is (inside the parentheses)";

int openingPositionTest = messageTest.IndexOf('(') + 1;
int closingPositionTest = messageTest.IndexOf(')');

int lengthTest = closingPositionTest - openingPositionTest;

string result = messageTest.Substring(openingPositionTest, lengthTest);

Console.WriteLine(result); */



