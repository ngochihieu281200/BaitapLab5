using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class PhanSo
    {
        public int tuso;
        public int mauso;
        public PhanSo() 
        {
            tuso = 0;
            mauso = 1;
        }
        public PhanSo(int soNguyen)
        {
            tuso = soNguyen;
            mauso = 1;
        }
        public PhanSo(int tuSoArg, int mauSoArg)
        {
            tuso = tuSoArg;
            mauso = mauSoArg;
        }
        public static PhanSo operator + (PhanSo a, PhanSo b)
        {
            int tuSoMoi = a.tuso * b.mauso + a.mauso * b.tuso;
            int mauSoMoi = a.mauso * b.mauso;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }
        public static PhanSo operator - (PhanSo a, PhanSo b)
        {
            int tuSoMoi = a.tuso * b.mauso - a.mauso * b.tuso;
            int mauSoMoi = a.mauso * b.mauso;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }
        public static PhanSo operator * (PhanSo a, PhanSo b)
        {
            int tuSoMoi = a.tuso  * b.tuso;
            int mauSoMoi = a.mauso * b.mauso;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            int tuSoMoi = a.tuso * b.mauso;
            int mauSoMoi = a.mauso * b.tuso;
            return new PhanSo(tuSoMoi, mauSoMoi);
        }
        public static bool operator > (PhanSo a, PhanSo b)
        {
            PhanSo kq = a - b;
            return kq.tuso > 0;
        }
        public static bool operator < (PhanSo a, PhanSo b)
        {
            PhanSo kq = a - b;
            return kq.tuso < 0;
        }
        public static bool operator >= (PhanSo a, PhanSo b)
        {

            return !(a < b);
        }
        public static bool operator <=(PhanSo a, PhanSo b)
        {

            return !(a > b);
        }
        public static bool operator == (PhanSo a, PhanSo b)
        {
            PhanSo kq = a - b;
            return kq.tuso == 0;
        }
        public static bool operator !=(PhanSo a, PhanSo b)
        {

            return !(a == b);
        }
        public override bool Equals(object o)
        {
            if (o == null)
                return false;
            var second = o as PhanSo;
            return second != null && tuso == second.tuso && mauso == second.mauso;
        }
        public override int GetHashCode()
        {
            return Tuple.Create(tuso, mauso).GetHashCode();
        }
        public void prettyPrint()
        {
            Console.WriteLine("gia tri la: " + tuso + "/" + mauso);
        }
        public static PhanSo Parse(string phanSo)
        {
            if (phanSo == null) throw new FormatException();
            string[] split = phanSo.Split('/');
            int len = split.Length;
            if (len == 2)
            {
                int s0 = int.Parse(split[0]);
                int s1 = int.Parse(split[1]);
                return new PhanSo(s0, s1);

            }
            else if (len == 4)
            {
                int s0 = int.Parse(split[0]);
                int s1 = int.Parse(split[1]);
                PhanSo f1 = new PhanSo(s0, s1);

                int s2 = int.Parse(split[2]);
                int s3 = int.Parse(split[3]);

                PhanSo f2 = new PhanSo(s2, s3);
                return f1 / f2;
            }
            else
                throw new FormatException();

        }
        static int gcd(int a, int b)
        {
            while (a != b)
                if (a < b) b = b - a;
                else a = a - b;
            return (a);
        }
        static int divvision(int a,int b)
        {
            int remainder = a, quotient = 0;
            while (remainder >= b)
            {
                quotient++;
            }
            return (quotient);

        }
        public static PhanSo Reduce(PhanSo phanSo)
        {
            int divisor, numerator, denominator, reducedNumerator, reducedDenominator;
            numerator = phanSo.tuso;
            denominator = phanSo.mauso;
            divisor = gcd(numerator, denominator);
            if (divisor != 1)
            {
                reducedNumerator = divvision(numerator, divisor);
                reducedDenominator = divvision(denominator, divisor);
                return new PhanSo(reducedNumerator, reducedDenominator);
            }
            else
                return phanSo;
        }
    }
}
