using CodeCool.FizzBuzzCooperation.Model;
using CodeCool.FizzBuzzCooperation.Service.Division;

namespace CodeCool.FizzBuzzCooperation.Service.Game;

public class GameService : IGameService
{
    private readonly IDivisionService _divisionService;
    public GameService(IDivisionService divisionService)
    {
        _divisionService = divisionService;
    }
    public string Play(int number, GameSpecification spec)
    {
        bool canDivide = false;
        foreach (var kvp in spec.GameRules)
        {
            GameRule gameRule = kvp.Value;
            canDivide = _divisionService.CanDivide(number, gameRule.ThisOperator, gameRule.Divisors);
            if (canDivide) return gameRule.Keyword;
        }
        return number.ToString();
    }
}