using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLogicalPrograms
{
    public class CouponNumber
    {
        public void Coupon()
        {
            Console.WriteLine("Enter the number of coupons want to generate");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int[] discoupon = new int[n];
            Random r = new Random();
            int count = 0;

            while (i < n)
            {
                int random = r.Next(10,100);
                Console.WriteLine(random);
                count++;
                if (discoupon.Contains(random))
                    //skip that particular iteration
                    continue;
                else
                    discoupon[i] = random;
                i++;
            }
            Console.WriteLine("Distinct coupon numbers are");
            foreach (int coupon in discoupon)
            {
                Console.Write(coupon + " ");
            }
            Console.WriteLine("From {1} random numbers {0} distinct number coupons are generated",n,count);

        }
    }
}
