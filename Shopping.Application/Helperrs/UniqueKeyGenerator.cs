using System.Security.Cryptography;
using System.Text;

namespace Shopping.Application.Helperrs;

public class UniqueKeyGenerator
{
    internal static readonly char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();

    /// <summary>
    /// Generates Unique Alphanumeric Key With Given Size
    /// Click <see cref="https://stackoverflow.com/a/1344255/9714376">the link</see> for detailed information
    /// </summary>
    /// <param name="size"></param>
    /// <returns></returns>
    public static string Create(int size)
    {
        byte[] data = new byte[4 * size];
        using (var crypto = RandomNumberGenerator.Create())
        {
            crypto.GetBytes(data);
        }

        StringBuilder result = new StringBuilder(size);
        for (int i = 0; i < size; i++)
        {
            var rnd = BitConverter.ToUInt32(data, i * 4);
            var idx = rnd % chars.Length;

            result.Append(chars[idx]);
        }

        return result.ToString();
    }
}