namespace MyLibrary
{
    public static class Class1
    {
        public static (bool, string) IsInt(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return (false, "empty");
            }

            if (int.TryParse(str, out _))
            {
                return (true, "");
            }
            else
            {
                return (false, "invalid");
            }
        }
    }
}