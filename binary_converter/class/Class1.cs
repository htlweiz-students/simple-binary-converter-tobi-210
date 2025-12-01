namespace BinaryNamespace
{
    public class BinaryConverter
{
    public int Convert(string binary)
    {
        int result = 0;

        foreach (char c in binary)
        {
            result = result * 2 + (int)(c - '0');
        }

        return result;
    }
}

}