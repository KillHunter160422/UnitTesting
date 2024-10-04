using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingLib.Math;

namespace UnitTesting.KillHunter
{
    public class BasicCalcTest
    {
        private readonly BasicCalc _isPerfectNum;

        public BasicCalcTest()
        { 
            _isPerfectNum = new BasicCalc();
        }

        [Fact]
        public void IsPerfectNumber_MustReturnTrue()
        {
            bool result = _isPerfectNum.IsPerfectNumber(6);
            Assert.True(result);
        }
        [Fact]
        public void IsPerfectNumber_MustReturnFalse()
        {
            bool result = _isPerfectNum.IsPerfectNumber(8);
            Assert.False(result);
        }

        [Fact]
        public void IsPerfectNumber_IncorrectData()
        {
            Assert.Throws<ArgumentOutOfRangeException>(()=>_isPerfectNum.IsPerfectNumber(-5));
        }

        [Theory]
        [InlineData(6, true)]
        [InlineData(8, false)]
        public void IsPerfectNumber_Theory(int n, bool expectedResult)
        {
            bool result = _isPerfectNum.IsPerfectNumber(n);
            Assert.Equal(expectedResult,result);
        }

    }
}
