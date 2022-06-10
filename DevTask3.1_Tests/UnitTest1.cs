using DevTask3;

namespace DevTask3._1_Tests
{
    public class Tests
    {

        [Test,TestCaseSource(nameof(TestCases))]
        public void Test_QuadEquation_Case1(Koef koef)
        {
            Assert.That((koef.x1, koef.x2), Is.EqualTo(Calc.QuadEquation(koef.a, koef.b, koef.c)));
        }

        public struct Koef
        {
            public double a;
            public double b;
            public double c;
            public double? x1;
            public double? x2;
            public Koef(double a, double b, double c,double? x1, double? x2)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.x1 = x1;
                this.x2 = x2;
            }
        }

        private static IEnumerable<Koef> TestCases
        {
            get
            {
                yield return new Koef(1, 2, -3, -3, 1);
                yield return new Koef(9, -21, 3, 0.153d,2.180d );
                yield return new Koef(3.4, 5.25, 6.3, null,null);
            }
        }


    }
}