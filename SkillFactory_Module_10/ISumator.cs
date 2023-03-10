using System.Numerics;

namespace SkillFactory_Module_10;

public interface ISumator<T> where T : INumber<T>
{
    T Sum(T left, T rigth)
    {
        return left + rigth;
    }
}
