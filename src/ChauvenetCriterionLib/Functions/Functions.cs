namespace Functions
{
    public static class Functions
    {
        public static string[] ReadTest(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            return lines;
        }
    }
}