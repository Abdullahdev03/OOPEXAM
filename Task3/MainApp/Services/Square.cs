public class Square : Shape
{
  public double _side = 1;
  public Square()
  {
    
  }
  public Square(double side)
  {
    _side = side;
  }
  public Square(double side, string color, bool filled) : base (color, filled)  
  {
    _side = side;
  }
  public double GetSide()
  {
    return _side;
  }
  public void SetSide(double side)
  {
    _side = side;
  }

  public override double GetArea()
  {
    return _side * _side;
  }

  public override double GetPerimeter()
  {
    return 4 * _side;
  }
  public override string ToString()
  {
    return $"Rectangle  {_color} {_filled} {_side}";
  }
}