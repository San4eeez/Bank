using BankMetod;
/*Bank bank1 = new Bank();
Bank bank2 = new Bank();
*/
int shetNumber = 3444444;
string fio = "Мавроди Сергей Пантелеевич";
float balance = 99999;

Bank[] Schet = new Bank[2];
Schet[0] = new Bank();
Schet[1] = new Bank();

int shetNumber2 = 6666;
string fio2 = "Апрашкин Валерий Мамадзиёвович";
float balance2 = 55;

Schet[0].otk(shetNumber, fio,balance);
Schet[1].otk(shetNumber2, fio2, balance2);




for (int i = 0; i < Schet.Length; i++)
{
    Schet[i].Out();
}

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



/*bank1.otk(shetNumber, fio, balance);
bank1.Out();

bank2.otk(shetNumber2, fio2, balance2);
bank2.Out();

Console.WriteLine("Пополнить счёт.");
Console.Write("Введите сумму: ");
float pmoney = float.Parse(Console.ReadLine());
bank1.Dob(pmoney);
bank1.Out();

Console.Write("Снять деньги со счёта.\nВведите сумму: ");
float smoney = float.Parse(Console.ReadLine());
bank1.Umen(smoney);
bank1.Out();

Console.Write("Обаличить счёт полностью.");
bank1.Obnul();
bank1.Out();

Console.Write("Перевод с счёта на счёт.\nВведите сумму: ");
float permpney = float.Parse(Console.ReadLine());
bank1.Umen(permpney);
bank2.Dob(pmoney);
bank1.Out();
bank2.Out();*/


/*while (true)
{
    Console.WriteLine("Что вы хоите сделать?\n1 - открыть счёт\n2 - показать информацию о счёте\n3 - положить деньги на счёт\n4 - снять со счёта\n5 - Обналичить счёт полностью\n6 - Перевести с одного счёта на другой");
    Console.Write("Ввод: ");
    Console.ReadLine();

   


}
*/
