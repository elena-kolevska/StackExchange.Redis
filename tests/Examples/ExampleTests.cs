using Xunit;

namespace Examples
{
    public class ExampleTests
    {

        [Fact]
        public void SetGetTest()
        {
            try
            {
                private SetGetExample example = new SetGetExample();
                example.SetGet();
            }
            catch (Exception e)
            {
                Assert.Null(e)
            }
        }

    }
}
