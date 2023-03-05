using System.Numerics;
using System.Security.AccessControl;

namespace SkillFactory_Module_10;

internal partial class Program
{
    public class SumOfTwoNumbers<T> : ISumator<T> where T : INumber<T>
    {

        private int firstNum;
        private int secondNum;
        private int result;

        public void SetValues()
        {
            lg.Event("Начало присвоения значений");
            firstNum = Int32.Parse(Console.ReadLine());
            lg.Event("Присвоено значение первого числа");
            secondNum = Int32.Parse(Console.ReadLine());
            lg.Event("Присвоено значение второго числа");
        }

        public void Calculate(Logger lg)
        {
            this.result = ((ISumator<int>)this).Sum(firstNum, secondNum);
            lg.Event("Сумма значений вычеслена успешно");
        }

        public void DisplayResult(Logger lg)
        {
            Console.WriteLine("Сумма двух чисел: {0}", result);
            lg.Event("Результат выведен на экран");
        }

        public T Sum(T left, T rigth)
        {
            throw new NotImplementedException();
        }

        T ISumator<T>.Sum(T left, T rigth)
        {
            return checked(left + rigth);
        }
    }
}