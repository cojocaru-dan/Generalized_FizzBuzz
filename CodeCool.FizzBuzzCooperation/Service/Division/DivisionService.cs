using CodeCool.FizzBuzzCooperation.Model;

namespace CodeCool.FizzBuzzCooperation.Service.Division;

public class DivisionService : IDivisionService
{
    public bool CanDivide(int number, Operator? op, params int[] divisors)
    {
        bool canDivideAll = true;
        bool canDivideOne = false;
        if (op == null) return CanDivide(number, divisors[0]);

        foreach (var divisor in divisors)
        {
            canDivideAll &= (number % divisor) == 0;
            canDivideOne |= (number % divisor) == 0;
        }
        return op == Operator.And ? canDivideAll : canDivideOne;
    }
    public bool CanDivide(int number, int divisor)
    {
        return number % divisor == 0;
    }
}