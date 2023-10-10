using BankMetod;
using System.Data.SqlTypes;

Random random = new Random();
/*Bank bank1 = new Bank();
Bank bank2 = new Bank();
*/





string hello1 = @"
                                                                                           
MMMMMMMM               MMMMMMMM                                  MMMMMMMM               MMMMMMMM
M:::::::M             M:::::::M                                  M:::::::M             M:::::::M
M::::::::M           M::::::::M                                  M::::::::M           M::::::::M
M:::::::::M         M:::::::::M                                  M:::::::::M         M:::::::::M
M::::::::::M       M::::::::::M        mmmmmmm    mmmmmmm        M::::::::::M       M::::::::::M
M:::::::::::M     M:::::::::::M      mm:::::::m  m:::::::mm      M:::::::::::M     M:::::::::::M
M:::::::M::::M   M::::M:::::::M     m::::::::::mm::::::::::m     M:::::::M::::M   M::::M:::::::M
M::::::M M::::M M::::M M::::::M     m::::::::::::::::::::::m     M::::::M M::::M M::::M M::::::M
M::::::M  M::::M::::M  M::::::M     m:::::mmm::::::mmm:::::m     M::::::M  M::::M::::M  M::::::M
M::::::M   M:::::::M   M::::::M     m::::m   m::::m   m::::m     M::::::M   M:::::::M   M::::::M
M::::::M    M:::::M    M::::::M     m::::m   m::::m   m::::m     M::::::M    M:::::M    M::::::M
M::::::M     MMMMM     M::::::M     m::::m   m::::m   m::::m     M::::::M     MMMMM     M::::::M
M::::::M               M::::::M     m::::m   m::::m   m::::m     M::::::M               M::::::M
M::::::M               M::::::M     m::::m   m::::m   m::::m     M::::::M               M::::::M
M::::::M               M::::::M     m::::m   m::::m   m::::m     M::::::M               M::::::M
MMMMMMMM               MMMMMMMM     mmmmmm   mmmmmm   mmmmmm     MMMMMMMM               MMMMMMMM                                                                                                                                                                                                                                                                                      
";
Console.WriteLine(hello1 + "\nДобро пожаловать в банк МММ, Сергей Пантелеевич приветствует вас!\n\n ");






int shetNumber = 344444;
string fio = "Мавроди Сергей Пантелеевич";
float balance = 99999;

int shetNumber2 = 666666;
string fio2 = "Апрашкин Валерчикс Санчезович";
float balance2 = 55;


Bank[] Schet = new Bank[3];
Schet[0] = new Bank();
Schet[1] = new Bank();
Schet[2] = new Bank();

Console.WriteLine("Запущена процедура создания счёта.");
Console.Write("Ваше имя: ");
int shetNumber3 = random.Next(100000, 999999);
string fio3 = Console.ReadLine();
float balance3 = 0;

Schet[0].otk(shetNumber, fio,balance);
Schet[1].otk(shetNumber2, fio2, balance2);
Schet[2].otk(shetNumber3, fio3, balance3);







Console.WriteLine("Список счетов банка.");

for (int i = 0; i < Schet.Length; i++)
{
    Console.Write(i+1 + " - ");
    Schet[i].Out();
}

Console.Write("\nВведите айди пользователя для авторизации: ");
int id = int.Parse(Console.ReadLine())-1;

Console.Clear();

while (true)
{
    
    Console.WriteLine("\n\nЧто вы хоите сделать?\n2 - показать информацию о счёте\n3 - положить деньги на счёт\n4 - снять со счёта\n5 - Обналичить счёт полностью\n6 - Перевести с одного счёта на другой");
    Console.Write("Ввод: ");
    int what = int.Parse(Console.ReadLine());

    if (what == 2)
    {
        Console.Clear();
        Schet[id].Out();
        
    }

    if (what == 3)
    {
        Console.Clear();
        Console.WriteLine("Пополнить счёт.");
        Console.Write("Введите сумму: ");
        float money = float.Parse(Console.ReadLine());
        if (money < 0)
        {
            Console.WriteLine("Дружок - пирожок, ты случайно ввёл минус, но я его исправил");
            money *= -1;
        }
        Schet[id].Dob(money);
    }

    if (what == 4)
    {
        Console.Clear();
        Console.WriteLine("Снять со счёта.");
        Console.Write("Введите сумму: ");
        float money = float.Parse(Console.ReadLine());
        if (money < 0)
        {
            Console.WriteLine("Дружок - пирожок, ты случайно ввёл минус, но я его исправил");
            money *= -1;
        }
        Schet[id].Umen(money);
    }

    if (what == 5)
    {
        Console.Clear();
        Console.WriteLine("Обаличить счёт полностью.");
        Schet[id].Obnul();
        Schet[id].Out();
    }

    if (what == 6)
    {
        Console.Clear();
        for (int i = 0; i < Schet.Length; i++)
        {
            Console.Write(i + 1 + " - ");
            Schet[i].Out();
        }
        Console.Write("Перевод с вашего счёта на другой.\nВведите айди счёта на который хотите сделать перевод: ");

        int id2 = int.Parse(Console.ReadLine())-1;
        Console.Write("Введите сумму: ");
        float money = float.Parse(Console.ReadLine());
        if (money < 0)
        {
            Console.WriteLine("\nДружок - пирожок, ты случайно ввёл минус, но я его исправил");
            money *= -1;
        }
        Console.WriteLine("\nИнформация о вашем счёте.");
        Schet[id].Umen(money);
        Console.WriteLine("\nИнформация для второго счёта.");
        Schet[id2].Dob(money);

    }

}

//здесь могла бы быть ваша реклама
