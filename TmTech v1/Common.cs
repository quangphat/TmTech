namespace TmTech_v1
{
    public static class Common
    {
        public static int ToInt(this string inputString)
        {
            int output = 0;
            try
            {
                output = int.Parse(inputString);
            }
            catch (System.Exception)
            {

                output = 0;
            }
            return output;
        }
    }
}
