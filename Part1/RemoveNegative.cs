public static class ArrayExtensions
{
    public static int[] RemoveNegatives(this int[] array)
    {
        if (array == null) throw new ArgumentNullException(nameof(array));

        return array.Where(x => x >= 0).ToArray();
    }

    public static bool ContainsChar(this string str, char character)
    {
        if (string.IsNullOrEmpty(str))
            return false;

        return str.Contains(character);
    }

}