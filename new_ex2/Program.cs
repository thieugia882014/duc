namespace T2008M_2.new_ex2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tiger t1 = new Tiger();
            Lion l1 = new Lion();
            t1.Setme(100,"tiger");
            l1.Setme(200,"lion");
            t1.Show();
            l1.Show();
        }
    }
}