using System;
using System.Text;

        (bool, int) IsPolindrome(string thestring)
        {
            string teststring;

            teststring = thestring.ToLower();

            var sb = new StringBuilder();
            foreach (char ch in teststring)
            {
                if (!char.IsPunctuation(ch) && !char.IsWhiteSpace(ch))
                {
                    sb.Append(ch);
                }
            }

            teststring = sb.ToString();

            int i = 0;
            int j = teststring.Length - 1;

            while( i <= j)
            {
                if (teststring[i] != teststring[j])
                {
                    return (false, 0);
                }

                i++;
                j--;
            }

            return (true, thestring.Length);
        }

string inputstr = "";
(bool b, int l) result;
Console.WriteLine("Let's begin:");
while(inputstr != "exit")
{
    inputstr = Console.ReadLine();
    if( inputstr != "exit")
    {
        result = IsPolindrome(inputstr);
        Console.WriteLine($"Polindrome: {result.b}, Length: {result.l}");
    }
}