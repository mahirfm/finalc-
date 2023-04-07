namespace finaltest1
{
    internal class Authors

    {
        int counter = 0;
        private int id;

        public Authors()
        {

            counter++;
            Id = counter;
        }


        public string Name { get; set; }
        public int SurName { get; set; }
        public int Id { get => id; private set => id = value; }

        public override string ToString()
        {
            return $"{Id}. {Name}";
        }







    }
}
