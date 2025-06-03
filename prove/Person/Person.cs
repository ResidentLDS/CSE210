class Person
{
    private string FirstName;
    private string LastName;
    private int Age;

    public Person()
    {
        FirstName = "";
        LastName = "";
        Age = 0;

    }

    public Person(string _lastName, string _firstName, int _age)
    {
        FirstName = _firstName;
        LastName = _lastName;
        Age = _age;
    }

    public string GetPersonInformation()
    {
        return ($"{FirstName} {LastName} : {Age}");
    }
}