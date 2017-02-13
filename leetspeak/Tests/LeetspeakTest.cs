using Xunit;

namespace LeetSpeakTranslator.Objects
{
    public class LeetSpeakTest
    {
        [Fact]
        public void Replaces_e_3()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak("tree");
            Assert.Equal("tr33", testLeetSpeak.Translate("tree"));
        }
        [Fact]
        public void Replaces_E_3()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak("TREE");
            Assert.Equal("TR33", testLeetSpeak.Translate("TREE"));
        }
        [Fact]
        public void Replaces_o_0()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak("tooth");
            Assert.Equal("t00th", testLeetSpeak.Translate("tooth"));
        }
        [Fact]
        public void Replaces_O_0()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak("TOOTH");
            Assert.Equal("T00TH", testLeetSpeak.Translate("TOOTH"));
        }
        [Fact]
        public void Replaces_I_1()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak("PIG");
            Assert.Equal("P1G", testLeetSpeak.Translate("PIG"));
        }
        [Fact]
        public void Replaces_i_1()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak("pig");
            Assert.Equal("pig", testLeetSpeak.Translate("pig"));
        }
        [Fact]
        public void Replaces_s_z()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak("Sassy");
            Assert.Equal("Sazzy", testLeetSpeak.Translate("Sassy"));
        }
        [Fact]
        public void Replaces_Sentence_Leetspeak()
        {
            LeetSpeak testLeetSpeak = new LeetSpeak("Don't you love these 'String' exercises? I do!" );
            Assert.Equal("D0n't y0u l0v3 th3z3 'String' 3x3rciz3z? 1 d0!", testLeetSpeak.Translate("Don't you love these 'String' exercises? I do!" ));
        }
    }
}
