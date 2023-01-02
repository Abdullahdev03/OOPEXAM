public class Circle
{
  public const double Pi = 3.14;
  public double _radius;
  public Circle()
  {
    
  }
  public Circle(double radius)
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
  public void GetArea()
  {
    System.Console.WriteLine(_radius * _radius * Pi);
  }
  public double GetCircumference()
  {
    return 2 * Pi * _radius;
  }
  public override string ToString()
  {
    return $"Radius of Circle =  {_radius}";
  }
}