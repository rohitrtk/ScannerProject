namespace ScannerProject
{
    internal abstract class Person
    {
        // The last name of the person
        protected string LastName {get;}
        
        // The first name of the person
        protected string FirstName {get;}

        // The ID number of the person, if Id = -1, person !is a student
        protected int Id;

        protected Person(string lastName, string firstName, int id)
        {
            LastName = lastName;
            FirstName = firstName;
            Id = id;
        }
    }
}