using NUnit.Framework;

namespace RegularExpressionMatching
{
    public class Tests
    {
        private RegularExpressionMatcher _matcher;
        [SetUp]
        public void Setup()
        {
            _matcher = new RegularExpressionMatcher();
        }

        [TestCase("aa", "aa", true)]
        [TestCase("aa", "..", true)]
        [TestCase("aa", "a", false)]
        [TestCase("aa", "a*", true)]
        [TestCase("ab", ".*", true)]
        [TestCase("aab", "c*a*b", true)]
        [TestCase("mississippi", "mis*is*p*.", false)]
        [TestCase("aab", "...", true)]
        [TestCase("awjfijfifjwijfiwab", ".*", true)]
        [TestCase("ab", ".*c", false)]
        [TestCase("aaa", "a*a", true)]
        [TestCase("aaa", "a*a*", true)]
        [TestCase("aaa", "a*a*c", false)]
        [TestCase("aaa", "a*ac", false)]
        public void Test1(string input, string pattern, bool expected)
        {
            Assert.AreEqual(expected, _matcher.IsMatch(input, pattern));
        }
    }
}