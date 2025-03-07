namespace PersonInfo
{
    internal class Citizen : IPerson
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}