class Program
{
    public static void Main()
    {
        Person myPerson = new Person("Bubba", "Bob", 53);

        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Cooper", "Steven", 39, "Glock");

        Console.WriteLine(myPoliceMan.GetPolicemanInformation());

        Doctor myDoctor = new Doctor("Hill", "Bobby", 58, "Stethiscope");

        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}