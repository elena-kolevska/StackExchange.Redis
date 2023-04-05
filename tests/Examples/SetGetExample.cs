// EXAMPLE: set_and_get
// HIDE_START
using System;
using StackExchange.Redis;

namespace Examples
{
    public class SetGetExample
    {
        public void SetGet()
        {
            // HIDE_END
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost:6379");
            IDatabase db = redis.GetDatabase();

            db.StringSet("bike:1", "Process 134");

            string value = db.StringGet("bike:1");
            Console.WriteLine(value);

            // HIDE_START
        }
    }
}
// HIDE_END
