namespace OOPtst
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age  { get; set; }
        public string city { get; set; }
        public string gender { get; set; }
        public void Introduct()
        {
            Console.WriteLine($"hello {Name} your information is \nage:{age}\nname:{Name}\ncity:{city}\nsexul:{gender}");
        }

    }

}

