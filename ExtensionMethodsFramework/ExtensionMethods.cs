namespace ExtensionsMethodsFramework
{
    public static class ExtensionsBase
    {
        public static bool IsNullOrEmpty(this string word)
        {
            return string.IsNullOrEmpty(word);
        }

        public static bool IsNullOrWhiteSpace(this string word)
        {
            return string.IsNullOrWhiteSpace(word);
        }

        public static bool IsNullOrEmpty(this object obj)
        {
            return obj == null ? false : true;
        }
    }
}
