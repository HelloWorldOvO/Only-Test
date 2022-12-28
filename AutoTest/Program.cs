namespace AutoTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int result = Mup.multiply(args);
            Console.WriteLine("mutiply result: " + result);
        }
    }

    public class Mup
    {
        public static int multiply(string[] args)
        {
            // 宣告變數
            int x = 0;
            int y = 0;
            string? s = null;

            Console.WriteLine(s ?? "s is nulls");

            /// 檢查輸入參數是否正確

            // 檢查數量
            if (args.Length < 2)
            {
                Console.WriteLine("Please type at least two characters");
                System.Environment.Exit(1);
            }

            // 檢查是否為數字
            bool isOK = true;
            isOK = isOK && int.TryParse(args[0], out x);
            isOK = isOK && int.TryParse(args[1], out y);
            if (isOK != true)
            {
                Console.WriteLine("Please input integer type");
                System.Environment.Exit(1);
            }

            // 顯示結果
            return x * y;
        }
    }
}