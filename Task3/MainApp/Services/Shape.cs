public abstract class Shape
{
  protected string _color;

  protected bool _filled = true;
  public Shape()
  {
    
  }
  public Shape(string color, bool filled)
  {
    _color = color;
    _filled = filled;
  }
  public string GetColor()
  {
    return _color; 
  }
  public void SetColor(string color)
  {
    _color = color;
  }
  public abstract double GetArea();
  public abstract double GetPerimeter();
  public override string ToString()
  {
    return $"Shape {_color} {_filled}";
  }
}