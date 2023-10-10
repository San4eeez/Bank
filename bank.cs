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
            Console.WriteLine($"Ваш номер: {nom},Ваше имя: {name}, Сумма: {sum}");
        }

        public void Dob(float money)
        {
            Console.WriteLine("Вы успешно добавили на счёт "+money);
            sum += money;
        }

        public void Umen (float money)
        {
            Console.WriteLine("Вы успешно сняли со счёта" +money);
            sum -= money;
        }

        public void Obnul() 
        {
            Console.WriteLine("Вы успешно сняли со счёта всю сумму.\nС вашего счёта списано "+sum);
            sum = 0;
        }

        public void perewod (float money)
        {
            Console.WriteLine($"Вы успешно перевели {money} на другой счёт");

        }




    }











}