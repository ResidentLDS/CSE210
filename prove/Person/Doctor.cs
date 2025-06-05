class Doctor : Person
{
    private string _tools;

    public Doctor(string _firstName, string _lastName, int _age, string tools)
    : base(_firstName, _lastName, _age)
    {
        _tools = tools;
    }

    public string GetDoctorInformation()
    {
        return $"{_tools} - {GetPersonInformation()}";
    }
}