// 1 вид. Ничего не принимают, не возвращают.

void Method1()
{
    Console.WriteLine("Автор...")
}
//Method1();

// 2 вид. Принимает, но не возвращает.

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        count++;
        
    }
}
Method21("Текст", 4);

// Вид 3. Не принимает, но возвращает.

uint Method3()
{
    return DateTime.Now.Year;
}
int year = Method3;
Console.WriteLine(year);

// Вид 4. Принимает и возвращает.

string Method4(int count, string c)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++) 
    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "asdf" );
Console.WriteLine(res)


for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{s}*{j} = {i*j}");
    }
    Console.WriteLine();
}


string text = "- Я думаю - сказал князь, улыбаясь - что, "
            + " ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласия просского короля"
            + "Вы так красноречивы. Вы дадите мне чаю?";


string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i< length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);