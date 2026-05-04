string Soundex(string str)
{
    Char[] list_occurrences=new Char[]{'a', 'e', 'i', 'o', 'u', 'y', 'h', 'w'};
    str=str.ToLower();
   
    for(int i = 1; i < str.Length; i++)
    {
        if(str[i]=='b' || str[i]=='f' || str[i]=='p' || str[i] == 'v')
        {
            str=str.Replace(str[i],'1');
        } else if (str[i]=='c' || str[i]=='g' || str[i]=='j' || str[i] == 'k' || str[i]=='q' || str[i] == 's' || str[i]=='x' || str[i] == 'z')
        {
            str=str.Replace(str[i],'2');
        } else if (str[i]=='d' || str[i]=='t')
        {
            str=str.Replace(str[i],'3');
        } else if (str[i]=='l')
        {
            str=str.Replace(str[i],'4');
        }else if (str[i]=='m' || str[i]=='n')
        {
            str=str.Replace(str[i],'5');
        }else if (str[i]=='r')
        {
            str=str.Replace(str[i],'6');
        }
    }

    foreach(var i in list_occurrences)
    {
        if (str.Contains(i) && str[0]!=i)
        {
            str=str.Replace(i,' ');
            
        }
    }
    
    str=str.Replace(" ","");
    if (str.Length > 4)
    {
        return str.Substring(0,5);
    } else if (str.Length < 4)
    {
        int counter=str.Length;
        while (counter<4)
        {
            str+="0";
            counter++;

        }
        return str;
    }
    return str;
}

Console.WriteLine(Soundex("World"));
