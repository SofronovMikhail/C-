string MyText = "Я думаю, сказал, князь улыбаясь-что,"
              + "вы бы взяли приступом согласие прусского короля"
              + "Вы так красноречивы. Вы дадите мне чаю?";
string MyReplay(string MyText, char oldText, char newText)
{
    string result = String.Empty;
    int length = MyText.Length;
    for(int i = 0; i < length; i++)
    {
        if(MyText[i] == oldText) 
        {
            result = result + $"{newText}";
        }
        else 
    {
        result = result + $"{MyText[i]}";
    }
    }
    return result;
}
string AAA = MyReplay(MyText, ' ', '|');
Console.WriteLine(AAA);
Console.WriteLine();
AAA = MyReplay(AAA, 'к', 'К');
Console.WriteLine(AAA);
Console.WriteLine();
AAA = MyReplay(AAA, 'С', 'с');
Console.WriteLine(AAA);
