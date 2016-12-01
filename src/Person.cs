namespace ScannerProject
{
    /// <summary>
    /// This class is the base class for any "person" that will be created
    /// i.e a student is a person, a teacher is a person
    /// </summary>
    public abstract class Person
    {
#region _VARIABLES_
        // The last name of the person
        public string LastName {get;}
        
        // The first name of the person
        public string FirstName {get;}

        // The ID number of the person
        public int Id;
#endregion

        /// <summary>
        /// Connstructor for a Person, assigns variables the paramters passed in
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        /// <param name="id"></param>
        protected Person(string lastName, string firstName, int id)
        {
            LastName = lastName;
            FirstName = firstName;
            Id = id;
        }
    }
}