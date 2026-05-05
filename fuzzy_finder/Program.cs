string Soundex(string str)
{
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
        }else if (str[i]=='a' || str[i]=='e' || str[i]=='i' || str[i] == 'o' || str[i]=='u' || str[i] == 'h' || str[i]=='w' || str[i] == 'y')
        {
            str=str.Replace(str[i],'0');
        }
    }
    return str;
    
}

Console.WriteLine(Soundex("World"));
