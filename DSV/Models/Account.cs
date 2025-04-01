namespace DSV.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string ImagePath { get; set; }

        public Account(int id, string name, string password, string imagePath)
        {
            ID = id;
            Name = name;
            Password = password;
            ImagePath = imagePath;
        }
    }
}
