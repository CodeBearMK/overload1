namespace overload1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 50, num2 = 30;
            int[] numAry = { 10, 20, 30, 70, 50 };

            CMath numberCal = new CMath();
            numberCal.GetMax(num1, num2);
            numberCal.GetMax(numAry);
            Console.Read();
        }
    }
}