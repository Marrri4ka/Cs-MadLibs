namespace MadLibs.Models
{
  public class VariablesLotr
  {
    private string _noun;
    private string _secondnoun;
    private string _verb;
    private string _adjective;

    public string GetNoun()
    {
      return _noun;
    }

    public void SetNoun(string newNoun)
    {
      _noun = newNoun;
    }

    public string GetSecondNoun()
    {
      return _secondnoun;
    }

    public void SetSecondNoun(string newSecondNoun)
    {
       _secondnoun = newSecondNoun;
    }

    public string GetVerb()
    {
      return _verb;
    }

    public void SetVerb(string newVerb)
    {
      _verb = newVerb;
    }

    public string GetAdjective()
    {
      return _adjective;
    }

    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }


  }
}
