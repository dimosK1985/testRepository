using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practice;

namespace UnitTests
{
    [TestClass]
    public class PythagoreanAnd1000Tests
    {

        [TestMethod]
        public void PythagoreanAnd1000_IdentifyNumber()
        {
            int maxNumber = 999;
            bool found;

            for (int a = 1; a < maxNumber; a++)
            {
                for (int b = 1; b < maxNumber; b++)
                {
                    for (int c = 1; c < maxNumber; c++)
                    {
                        if (a + b + c != 1000)
                        {
                            continue;
                        }

                        if (StaticHelperMethods.IsAbcPythagoreanAndSums1000(
                            new uint[] { (uint)a, (uint)b, (uint)c }))
                        {
                            found = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
