using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("決勝時刻:BMI");
            double m;
            double kg;
            double bmi;
                Console.WriteLine("請輸入身高(m):");
                m = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("請輸入體重(kg):");
                kg = Convert.ToDouble(Console.ReadLine());
                bmi = kg / (m * m);
                Console.WriteLine("你的BMI是:" + bmi);
                if (m == 0 | kg == 0)
                {
                    Console.WriteLine("不填數字是要怎麼決戰啦!");
                }

                if(bmi < 18.5)
                {
                    Console.WriteLine("你個竹竿");
                }
                if (bmi >= 18.5 && bmi < 24)
                {
                    Console.WriteLine("你只是個凡人");
                }
                if (bmi >= 24 && bmi < 27)
                {
                    Console.WriteLine("資質過人喔");
                }
                if (bmi >= 27 && bmi < 30)
                {
                    Console.WriteLine("挖 高手");
                }
                if (bmi >= 30 && bmi < 35)
                {
                    Console.WriteLine("牛B 牛B");
                }
                if (bmi >= 35)
                {
                    Console.WriteLine("太神啦");
                }
                Console.WriteLine("因為我的迴圈弄不出來所以就再重開一次吧呵呵");
                Console.Read();           
        }
    }
}
