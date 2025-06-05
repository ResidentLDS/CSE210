class PoliceMan : Person
{
    private string _weapons;
    public PoliceMan(string _firstName, string _lastName, int _age, string weapons)
    : base(_firstName, _lastName, _age)
    {
        _weapons = weapons;
    }
    public string GetPolicemanInformation()
    {
        return $"{_weapons} - {GetPersonInformation()}";
    }
}