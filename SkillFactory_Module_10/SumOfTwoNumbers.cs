using System.Numerics;
using System.Security.AccessControl;

namespace SkillFactory_Module_10;
public class SumOfTwoNumbers : ISumator<int>
{
    private int firstNum;
    private int secondNum;
    private int result;
    ILogger lg;

    public SumOfTwoNumbers(ILogger lg)
    {
        this.lg = lg;
    }
    public void SetValues()
    {
        lg.Event("Начало присвоения значений");
        firstNum = Int32.Parse(Console.ReadLine());
        lg.Event("Присвоено значение первого числа");
        secondNum = Int32.Parse(Console.ReadLine());
        lg.Event("Присвоено значение второго числа");
    }

    public void Calculate()
    {
        this.result = Sum(firstNum, secondNum);
        lg.Event("Сумма значений вычеслена успешно");
    }

    public void DisplayResult()
    {
        Console.WriteLine("Сумма двух чисел: {0}", result);
        lg.Event("Результат выведен на экран");
    }

    public int Sum(int left, int rigth)
    {
        return left + rigth;
    }
}