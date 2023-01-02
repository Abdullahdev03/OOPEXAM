public class Circle : Shape
{
  public double _radius = 1;
  public const double Pi = 3.14;
  public Circle()
  {
    
  }
  public Circle(double radius)
  {
    _radius = radius;
  }
  public Circle(double radius, string color, bool filled) : base(color, filled)
  {
    _radius = radius;
  }
  public double GetRadius()
  {
    return _radius;
  }
  public void SetRadius(double radius)
  {
    _radius = radius;
  }
  public override double GetArea()
  {
    return Pi*(_radius*_radius);
  }

  public override double GetPerimeter()
  {
    return 2*_radius * Pi;
  }
  public override string ToString()
  {
    return $"Circle {_color} {_filled} {_radius}";
  }
}