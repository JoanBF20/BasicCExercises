namespace Exercise1Foreach
{
    internal class PersonModel
    {
        public PersonModel(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}