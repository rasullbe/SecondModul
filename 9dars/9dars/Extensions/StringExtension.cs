namespace _9dars.Extensions;

public static class StringExtension
{
    public static int GetCount(this string name)
    {
        int count = 0;
        foreach(char c in name)
        {
            if (char.IsLetter(c)) count++;
        }
        return count;
    }


    public static string GetFirstLetter(this string name)
    {
        foreach (char c in name)
        {
            if (char.IsLetter(c))
                return c.ToString();
        }

        return "";
    }

}