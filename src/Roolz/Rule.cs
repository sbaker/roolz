namespace Roolz;

public class Rule : IRule
{
  public Task<IRuleResult> Execute()
  {
    return Task.FromResult<IRuleResult>(new RuleResult());
  }
}