using LongestPalindromicSubstring;
using NUnit.Framework;
using System.Diagnostics;

namespace Tests
{
    public class Tests
    {
        private PalindromicSubstring _palindromicSubstring;
        [SetUp]
        public void Setup()
        {
            _palindromicSubstring = new PalindromicSubstring();
        }

        [TestCase("babad", "bab")]
        [TestCase("cbbd", "bb")]
        [TestCase("a", "a")]
        [TestCase("ac", "a")]
        [TestCase("abbaabba", "abbaabba")]
        [TestCase("sabbaabba", "abbaabba")]
        [TestCase("abbaabbas", "abbaabba")]
        [TestCase("aacabdkacaa", "aca")]
        [TestCase("aaaabaaa", "aaabaaa")]
        
        public void Test1(string input, string expected)
        {
            Assert.AreEqual(expected, _palindromicSubstring.LongestPalindrome(input));
        }

        [TestCase("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz", "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz")]
        public void TestLongString(string input, string expected)
        {
            var sw = Stopwatch.StartNew();
            Assert.AreEqual(expected, _palindromicSubstring.LongestPalindrome(input));
            var elapsed = sw.ElapsedMilliseconds;
        }
    }
}