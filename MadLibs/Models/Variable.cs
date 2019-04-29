namespace MadLibs.Models
{
  public class Variable
  {
    private string _name;
    private string _noun;
    private string _secondnoun;
    private string _adjective;
    private string _color;

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

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

    public string GetAdjective()
    {
      return _adjective;
    }

    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }

    public string GetColor()
    {
      return _color;
    }

    public void SetColor(string newColor)
    {
      _color = newColor;
    }







  }

}
