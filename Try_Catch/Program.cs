namespace Try_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////string x = "Test";
            ////int y = int.Parse(x);

            //int x = 25, y = 0;

            //int result = x / y;


            int result = 0;


            //while(true)
            //{
            //    try
            //    {
            //        int x = int.Parse(Console.ReadLine());
            //        int y = int.Parse(Console.ReadLine());
            //        result = x + y;
            //        Console.WriteLine("Your result is:"  + result);
            //        break;
            //    }
            //    catch (Exception ex)
            //    {

            //        Console.WriteLine("Your parameter format is incorrect" + Environment.NewLine + "Please re enter your parameters");
            //    }
            //}





            //try
            //{

            //    //int x = 20;
            //    //int y = 0;
            //    //int r = x / y;

            //    string x = "Test";
            //    int y = int.Parse(x);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Your exception is:");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FormatException ex)
            //{

            //}
            //catch (Exception ex)
            //{

            //}
            
            try
            {
                //opeen connect
                // do something
                int x = 0;
                int y = 15;
                int re = y / x;
            


            }
            catch (Exception ex)
            {

                switch (ex)
                {
                    case DivideByZeroException:
                        Console.WriteLine("Divide");
                        break;
                    case FormatException:
                        Console.WriteLine("Format");
                        break;
                    default:
                        break;
                }
            }






            Console.ReadLine();
        }


    }
}