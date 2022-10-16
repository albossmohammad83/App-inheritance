public class BookWriter : Writer
{
    
     public  BookWriter(string firstName, string lastName) : base(firstName, lastName)
   {
    
   }

  public override void Vlog()
    {
         System.Console.WriteLine("I vlog using my iPhone.");
    }
    public override void Write()
    {
         System.Console.WriteLine("I write books.");
    }
}