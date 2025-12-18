namespace OOPtst
{
    public class Student : Person

    {
        public void stdIntroduct() {

            Console.WriteLine($"Your StudentId is : {StudentId}");
        }
        public int StudentId { get; set; }


    }
}
