//Console.WriteLine("Emailingizni kiriting:");
string str = "example@gmail.com";
var strTest = "!#$%^&*(){}[]?><.,';:|";
var strError = "ASDFGHJKLQWERTYUIOPZXCVBNM";
for (int i = 0; i < strTest.Length; i++)
{
    for (int j = 0; j < str.Length; j++)
    {
        if (strTest[i] == str[j])
        {
            Console.WriteLine(strTest[i] + " xato");
        }
    }
}

for (int i = 0; i < strError.Length; i++)
{
    for (int j = 0; j < str.Length; j++)
    {
        if (strError[i] == str[j])
        {
            Console.WriteLine(str.ToLower());
        }
    }
}





