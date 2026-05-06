using System.ComponentModel.Design.Serialization;

string Soundex(string str)
{
    str=str.ToLower();
    
    Stack<char> letters=new Stack<char>();
    letters.Push(str[0]);
    for(int i = 1; i < str.Length && letters.Count<4; i++)
    {
        if (letters.Peek()==str[i])
        {
            continue;
        }
        else if(str[i]=='b' || str[i]=='f' || str[i]=='p' || str[i] == 'v')
        {
            letters.Push('1');
        } else if (str[i]=='c' || str[i]=='g' || str[i]=='j' || str[i] == 'k' || str[i]=='q' || str[i] == 's' || str[i]=='x' || str[i] == 'z')
        {
            letters.Push('2');
        } else if (str[i]=='d' || str[i]=='t')
        {
            letters.Push('3');
        } else if (str[i]=='l')
        {
            letters.Push('4');
        }else if (str[i]=='m' || str[i]=='n')
        {
            letters.Push('5');
        }else if (str[i]=='r')
        {
            letters.Push('6');
        }else if (str[i]=='a' || str[i]=='e' || str[i]=='i' || str[i] == 'o' || str[i]=='u' || str[i] == 'h' || str[i]=='w' || str[i] == 'y')
        {
            letters.Push('0');
        }
    }
    string result=new string(letters.ToArray().Reverse().ToArray());
    var counter=0;
    while (result.Length < 4)
    {
        result+='0';
        counter++;
    }
    return result;
    
}

var lines=File.ReadAllLines("last-names.txt");
Dictionary<string,string[]> pairs=new Dictionary<string, string[]>();


foreach (var line in lines)
{
    pairs[Soundex(line)].Append(line);       
}

foreach(var key in pairs.Keys)
{
    if (pairs[key].Length > 1)
    {
        foreach(var value in pairs[key])
        {
            Console.Write(value);
        }
        Console.WriteLine();
    }
}