using FluentAssertions;
using LeetCode.OtherProblems.Medium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSolutions.OtherProblems.Medium
{
    [TestClass]
    public class LongestPalindromicSubstringTest
    {
        [TestMethod]
        public void LongestPalindromeTestCase1()
        {
            var input = "babad";
            LongestPalindromicSubstring.LongestPalindrome(input).Should().Be("bab");
        }
        
        [TestMethod]
        public void LongestPalindromeTestCase2()
        {
            var input = "cbbd";
            LongestPalindromicSubstring.LongestPalindrome(input).Should().Be("bb");
        }
        
        [TestMethod]
        public void LongestPalindromeTestCase3()
        {
            var input = "a";
            LongestPalindromicSubstring.LongestPalindrome(input).Should().Be("a");
        }
        
        [TestMethod]
        public void LongestPalindromeTestCase4()
        {
            var input = "ac";
            LongestPalindromicSubstring.LongestPalindrome(input).Should().Be("a");
        }
        
        [TestMethod]
        public void LongestPalindromeTestCase5()
        {
            var input = "bb";
            LongestPalindromicSubstring.LongestPalindrome(input).Should().Be("bb");
        }
        
        [TestMethod]
        public void LongestPalindromeTestCase6()
        {
            var input = "zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz";
            LongestPalindromicSubstring.LongestPalindrome(input).Should().Be("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
        }
        
        [TestMethod]
        public void LongestPalindromeTestCase7()
        {
            var input = "vyzonecajxxdvswhftixmzgjbfoeilbnchqmdgoxfmkkkkcqguavfozmplhzgothrwpukzgkctdacbxefrzrmbgwwrrhpcvqwvgwgknyrtxxoligsqpbqoucltakbkywwssyodzydsjxeuvgiqqitkfkqnxsfflgbjvbxdrworsdkowtkgabnszgsmgytupybdclmmsmougfendwvzarfdfbixjnlxvevqfoohcgrrysofifdfulygrmkwpimduzzluojeqixdtcxhcqnfsdbunmhsglhiplgbhrqrrrprffjfradvbifxxhoqylkejyprxdtianietnjumltxywfowopghurofvwtxvaxtqnjbzwvljjwfmmlhixogwwyaoysvrpgfymyqjschhqcwvytkreirdxfapaomayebhkzxgmlthoxialmtnilfopvhhqlocytyrtpfmpgqakdbrsteurcpfvruicuxzukfpwjwgnuaaungwjwpfkuzxuciurvfpcruetsrbdkaqgpmfptrytycolqhhvpoflintmlaixohtlmgxzkhbeyamoapafxdrierktyvwcqhhcsjqymyfgprvsyoaywwgoxihlmmfwjjlvwzbjnqtxavxtwvforuhgpowofwyxtlmujnteinaitdxrpyjeklyqohxxfibvdarfjffrprrrqrhbglpihlgshmnubdsfnqchxctdxiqejoulzzudmipwkmrgylufdfifosyrrgchoofqvevxlnjxibfdfrazvwdnefguomsmmlcdbyputygmsgzsnbagktwokdsrowrdxbvjbglffsxnqkfktiqqigvuexjsdyzdoysswwykbkatlcuoqbpqsgiloxxtrynkgwgvwqvcphrrwwgbmrzrfexbcadtckgzkupwrhtogzhlpmzofvaugqckkkkmfxogdmqhcnblieofbjgzmxitfhwsvdxxjacenozyv";
            LongestPalindromicSubstring.LongestPalindrome(input).Should().Be("vyzonecajxxdvswhftixmzgjbfoeilbnchqmdgoxfmkkkkcqguavfozmplhzgothrwpukzgkctdacbxefrzrmbgwwrrhpcvqwvgwgknyrtxxoligsqpbqoucltakbkywwssyodzydsjxeuvgiqqitkfkqnxsfflgbjvbxdrworsdkowtkgabnszgsmgytupybdclmmsmougfendwvzarfdfbixjnlxvevqfoohcgrrysofifdfulygrmkwpimduzzluojeqixdtcxhcqnfsdbunmhsglhiplgbhrqrrrprffjfradvbifxxhoqylkejyprxdtianietnjumltxywfowopghurofvwtxvaxtqnjbzwvljjwfmmlhixogwwyaoysvrpgfymyqjschhqcwvytkreirdxfapaomayebhkzxgmlthoxialmtnilfopvhhqlocytyrtpfmpgqakdbrsteurcpfvruicuxzukfpwjwgnuaaungwjwpfkuzxuciurvfpcruetsrbdkaqgpmfptrytycolqhhvpoflintmlaixohtlmgxzkhbeyamoapafxdrierktyvwcqhhcsjqymyfgprvsyoaywwgoxihlmmfwjjlvwzbjnqtxavxtwvforuhgpowofwyxtlmujnteinaitdxrpyjeklyqohxxfibvdarfjffrprrrqrhbglpihlgshmnubdsfnqchxctdxiqejoulzzudmipwkmrgylufdfifosyrrgchoofqvevxlnjxibfdfrazvwdnefguomsmmlcdbyputygmsgzsnbagktwokdsrowrdxbvjbglffsxnqkfktiqqigvuexjsdyzdoysswwykbkatlcuoqbpqsgiloxxtrynkgwgvwqvcphrrwwgbmrzrfexbcadtckgzkupwrhtogzhlpmzofvaugqckkkkmfxogdmqhcnblieofbjgzmxitfhwsvdxxjacenozyv");
        }
    }
}