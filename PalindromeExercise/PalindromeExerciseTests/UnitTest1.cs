using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]//[Fact]
        [InlineData("racecar", true)]//one of the first items to look for in a code wars problem is its return type.
        [InlineData("crap", false)]
        public void Test1(string word, bool expected)
        {
            //array
            var tester = new WordSmith();
            //actual
            var actual = tester.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);//doesn'tmatter in what order these two arguments are written here.
        }
    }
}
