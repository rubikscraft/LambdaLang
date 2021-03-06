using Sprache;
using LambdaLang.Scopes;

namespace LambdaLang.Solvables
{
  public class Variable : Solvable
  {
    public string value;

    public Variable(string value)
    {
      this.value = value;
    }

    public override Result Solve(Scope scope)
    {
      return scope.Retrieve(value);
    }

    public override string ToString()
    {
      return value;
    }
  }
}