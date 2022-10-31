#region Tekrarlamayan Rakamlardan Şifre Üretimi.

char[] karakter = new char[10];
int i = 0;


for (char k = '0'; k <= '9'; k++)
{
    karakter[i] = k;
    i++;
}

Console.WriteLine();


string sifre = "";
int dizisayaci = 0;

int[] kontrol = new int[6];
Random uret = new Random();
for (i = 0; i <= 5; i++)
{
bas:
    dizisayaci = uret.Next(0, 9);
    kontrol[i] = karakter[dizisayaci];

    for (int con = 0; con < i; con++)
    {
        if (kontrol[con] == kontrol[i])
        {
            goto bas;
        }
    }

    sifre = sifre + karakter[dizisayaci];
}


Console.WriteLine("Üretilmiş olan şifre = " + sifre);

Console.ReadKey();


#endregion