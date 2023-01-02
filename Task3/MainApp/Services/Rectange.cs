public class Rectange : Shape
{
  public double _width;
  public double _height;
  public Rectange()
  {
    
  }
  public Rectange(double width, double height)
  {
    _width = width;
    _height = height;
  }
  public Rectange(double width, double height, string color, bool filled) : base (color, filled)
  {
    _width = width;
    _height = height;
  }
  public double GetWidth()
  {
    return _width;
  }
  public void SetWidth(double width)
  {
    _width = width;
  }
    public double GetHeight()
  {
    return _height;
  }
  public void SetHeight(double height)
  {
    _height = height;
  }

  public override double GetArea()
  {
    return _width * _height;
  }

  public override double GetPerimeter()
  {
    return 2*(_width + _height);
  }
  public override string ToString()
  {
    return $"Rectangle  {_color} {_filled} {_width}{_height}";
  }
}