using System.Data;

namespace Tool;

public class Tools
{
    static Random random = new Random();

    public static int RandomNumber(int max)
    {
        return random.Next(max);
    }
    public static int RandomNumber(int min, int max)
    {
        return random.Next(min, max);
    }
}