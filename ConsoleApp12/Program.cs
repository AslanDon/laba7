Console.WriteLine("Vvedite stroku;");
string str = Console.ReadLine();
int count = 0;

string[] kuki = str.Split(' ');
string str1 = kuki[kuki.Length - 1];

for(int i = 0; i < str1.Length; i++)
{
    if (str1[i] == 'a')
    {
        count++;
    }
}

Console.WriteLine(count);