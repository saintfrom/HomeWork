using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1.Создание нескольких переменных разных типов, в которых могут храниться данные
            //Что нужно сделать
            //Некоторая компания заинтересована в том, чтобы вы создали для неё приложение ― записную книжку. Сейчас в компании работает три сотрудника, именно они и будут пользователями приложения.
            //Создайте переменные для этих пользователей.При этом раскрывать свои персональные данные они не захотели и предпочитают вводить их самостоятельно.
            //Итого для каждого пользователя должны быть доступны переменные под следующие данные:
            //имя, возраст, рост, баллы по русскому языку, баллы по истории, баллы по математике.
            //При решении подумайте, какой тип данных под какую переменную подходит больше всего.

            Console.WriteLine("Введите имя пользователя №1 и нажмите Enter");
            string name1 = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя №1 и нажмите Enter");
            int age1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите рост пользователя №1 и нажмите Enter");
            int height1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите балл по русскому языку пользователя №1 и нажмите Enter");
            int ballRu1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите балл по истории и нажмите Enter");
            int ballHis1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баллы по математике и нажмите Enter");
            int ballMath1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите имя пользователя №2 и нажмите Enter");
            string name2 = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя №2 и нажмите Enter");
            int age2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите рост пользователя №2 и нажмите Enter");
            int height2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите балл по русскому языку пользователя №2 и нажмите Enter");
            int ballRu2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите балл по истории пользователя №2 и нажмите Enter");
            int ballHis2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баллы по математике пользователя №2 и нажмите Enter");
            int ballMath2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите имя пользователя №3 и нажмите Enter");
            string name3 = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя №3 и нажмите Enter");
            int age3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите рост пользователя №3 и нажмите Enter");
            int height3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите балл по русскому языку пользователя №3 и нажмите Enter");
            int ballRu3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите балл по истории пользователя №3 и нажмите Enter");
            int ballHis3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баллы по математике пользователя №3 и нажмите Enter");
            int ballMath3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Пользователь №1 : {name1} Возраст: {age1} Рост: {height1} Балл по русскому: {ballRu1}  Балл по истории: {ballHis1} Балл по математике {ballMath1}");
            Console.WriteLine($"Пользователь №2 : {name2} Возраст: {age2} Рост: {height2} Балл по русскому: {ballRu2}  Балл по истории: {ballHis2} Балл по математике {ballMath2}"); 
            Console.WriteLine($"Пользователь №3 : {name3} Возраст: {age3} Рост: {height3} Балл по русскому: {ballRu3}  Балл по истории: {ballHis3} Балл по математике {ballMath3}");



        }
    }
}
