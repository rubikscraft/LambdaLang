using Sprache;
using LambdaLang.Scopes;

namespace LambdaLang.Solvables
{
  public class Number : Solvable
  {
    public decimal value;

    public Number(decimal value)
    {
      this.value = value;
    }

    public override Result Solve(Scope scope)
    {
      return new ConstantResult(value);
    }

    public override string ToString()
    {
      return value.ToString();
    }
  }
}