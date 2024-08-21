namespace Roolz
{
  public interface IRule
  {
    Task<IRuleResult> Execute();
  }
}
