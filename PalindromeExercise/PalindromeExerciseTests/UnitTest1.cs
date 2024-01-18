using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        
        [Theory]
        [InlineData("madam", true)]
        [InlineData("racecar", true)]
        [InlineData("mother", false)]
        [InlineData("butterfly", false)]
        [InlineData("Level", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindrome(string word, bool expected)
        {
            var x = new WordSmith();
            var actual = x.IsAPalindrome(word);
            Assert.Equal(actual, expected);

        }
    }
}
