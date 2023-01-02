public class Employee
{
  private int _id;
  private string _FirstName;
  private string _LastName;
  private int _salary;

  public Employee(int id, string firstName, string lastName, int salary)
  {
    _id = id;
    _FirstName = firstName;
    _LastName = lastName;
    _salary = salary;
  }
  public int GetId()
  {
    return _id;
  }
  public string GetFirstName()
  {
    return _FirstName;
  }
  public string GetLastName()
  {
    return _LastName;
  }
  public string GetName()
  {
    return $"FirstName: {_FirstName} LastName: {_LastName}";
  }
  public int GetSalary()
  {
    return _salary;
  }
  public void SetSalary(int salary)
  {
    _salary = salary;
  }
  public int GetAnnualSalary()
  {
    return _salary * 12;  
  }
  public int RaiseSalary(int percents)
  {
    return _salary + ((_salary * percents)/100);
  }
  public override string ToString()
  {
    return $"Youre id ={_id} name ={_FirstName} {_LastName}, salary = {_salary} ";
  }

}