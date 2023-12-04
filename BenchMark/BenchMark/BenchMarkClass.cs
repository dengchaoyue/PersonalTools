namespace Benchmark
{
    using BenchmarkDotNet.Attributes;
    using System.Collections.Generic;
    using System.Xml.Linq;

    public class BenchMark
    {
        enum TestEnum
        {
            TestValue0 = 0,
            TestValue2,
            TestValue3,
            TestValue4,
            TestValue5,
            TestValue6,
            TestValue7,
            TestValue8,
            TestValue9,
            TestValue10,
            TestValue11,
            TestValue12,
            TestValue13,
            TestValue14,
            TestValue15,
            TestValue16,
            TestValue17,
            TestValue18,
            TestValue19,
            TestValue20,
            TestValue21,
            TestValue22,
            TestValue23,
            TestValue24,
            TestValue25,
            TestValue26,
            TestValue27,
            TestValue28
        }

        [MemoryDiagnoser]
        public class EnumAnyTest
        {
            private readonly IEnumerable<TestEnum> value = Enum.GetValues(typeof(TestEnum)).Cast<TestEnum>();

            public EnumAnyTest()
            {
            }

            private int HandleHashCode(string test, int i)
            {
                return test.GetHashCode() + i;
            }

            [Benchmark]
            public void EnumAny()
            {
                for (int i = 0; i < 1000000; i++)
                {
                    var isNullEnum = value.Any();
                    //HandleHashCode(isNullEnum.ToString(), i);
                }
            }

            [Benchmark]
            public void EnumToListCount()
            {
                for (int i = 0; i < 1000000; i++)
                {
                    var isNullEnum = value.ToList().Count;
                    //HandleHashCode(isNullEnum.ToString(), i);
                }
            }
        }
    }
}
