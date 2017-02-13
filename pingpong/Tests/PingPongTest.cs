using Xunit;

namespace PingPongModule.Objects
{
    public class PingPongTest
    {
        // [Fact]
        // public void PingPongFilter_ReturnNumber1_false()
        // {
        //     PingPong testPingPong = new PingPong(1);
        //     Assert.Equal(false, testPingPong.PingPongFilter(1));
        // }
        //
        // [Fact]
        // public void PingPongFilter_ReturnNumber3_ping()
        // {
        //     PingPong testPingPong = new PingPong(3);
        //     Assert.Equal(true, testPingPong.PingPongFilter(3));
        // }
        [Fact]
        public void PingPongFilter_ReturnNumber1_1()
        {
            PingPong testPingPong = new PingPong(1);
            Assert.Equal("1", testPingPong.PingPongFilter(1));
        }
        [Fact]
        public void PingPongFilter_ReturnNumber3_Ping()
        {
            PingPong testPingPong = new PingPong(3);
            Assert.Equal("Ping", testPingPong.PingPongFilter(3));
        }
        [Fact]
        public void PingPongFilter_ReturnNumber5_Pong()
        {
            PingPong testPingPong = new PingPong(5);
            Assert.Equal("Pong", testPingPong.PingPongFilter(5));
        }
        [Fact]
        public void PingPongFilter_ReturnNumber15_PingPong()
        {
            PingPong testPingPong = new PingPong(15);
            Assert.Equal("PingPong", testPingPong.PingPongFilter(15));
        }
    }
}
