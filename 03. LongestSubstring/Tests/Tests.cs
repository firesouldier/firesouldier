using LongestSubstring;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {

        private GetLongestSubstring _longestSubstring;
        [SetUp]
        public void Setup()
        {
            _longestSubstring = new GetLongestSubstring();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(3, _longestSubstring.LengthOfLongestSubstring("abcabcbb"));
            Assert.AreEqual(1, _longestSubstring.LengthOfLongestSubstring("bbbbb"));
            Assert.AreEqual(3, _longestSubstring.LengthOfLongestSubstring("pwwkew"));
            Assert.AreEqual(0, _longestSubstring.LengthOfLongestSubstring(""));
        }

        [Test]
        public void CustomTests()
        {
            Assert.AreEqual(12, _longestSubstring.LengthOfLongestSubstring("123    -'¨3qwerty:"));
            Assert.AreEqual(8, _longestSubstring.LengthOfLongestSubstring("/%3!2¤5hhffddss1123"));
            Assert.AreEqual(12, _longestSubstring.LengthOfLongestSubstring("zxcvb00?´`'-_:.;,@"));
            Assert.AreEqual(3, _longestSubstring.LengthOfLongestSubstring("dvdf"));
        }
    }
}