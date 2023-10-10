using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMetod
{
    internal class Bank
    {
        private int nom;
        private string name;
        private float sum;

        public void otk(int nom,string name,float sum)
        {
            this.nom = nom;
            this.name = name;
            this.sum = sum;
        }

        public void Out()
        {
            Console.WriteLine($"Номер счёта: {nom}. ФИО: {name}.Сумма: {sum}.");
        }

        public void Dob(float money)
        {
            Console.WriteLine("Вы успешно добавили на счёт "+money);
            sum += money;
            Console.WriteLine($"Ваш баланс: {sum}");
        }

        public void Umen (float money)
        {
            Console.WriteLine("Вы успешно сняли со счёта " +money);
            sum -= money;
            if (sum < 0)
            {
                Console.WriteLine("Благодарим вас за использование услуги оведрафт");
            }
            Console.WriteLine($"Ваш баланс: {sum}");
        }

        public void Obnul() 
        {
            Console.WriteLine("Вы успешно сняли со счёта всю сумму.\nС вашего счёта списано "+sum);
            sum = 0;
        }

        public void perewod (float money)
        {
            Console.WriteLine($"Вы успешно перевели {money} на другой счёт");
            if (sum < 0)
            {
                Console.WriteLine("Благодарим вас за использование услуги оведрафт");
            }

        }
       
    }
    //здесь могла бы быть ваша реклама









}