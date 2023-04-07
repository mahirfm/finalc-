namespace finaltest1
{
    public class Books
    {
        int counter = 0;
        private int id;

        public Books()
        {

            counter++;
            Id = counter;
        }


        public int Id { get => id; private set => id = value; }
        public string Name { get; set; }
        public int AuthorID { get; set; }

        public Genre Genre { get; set; }
        public int PageCount { get; set; }
        public ushort Price { get; set; }




        public override string ToString()
        {
            return $"id:\n{Id}.Adi:\n{Name}Muellifi :\n{AuthorID} \n Janri:\n{Genre} \nSeifeSayi:\n{PageCount}\nQiymeti:\n{Price} ";
        }

    }
}
