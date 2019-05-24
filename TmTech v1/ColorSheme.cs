using System.Drawing;

namespace TmTech_v1
{
    public static class ColorExtension
    {
        /// <summary>
        /// Convert an integer number to a Color.
        /// </summary>
        /// <returns></returns>
        public static Color ToColor(this int argb)
        {
            return Color.FromArgb(
                (argb & 0xff0000) >> 16,
                (argb & 0xff00) >> 8,
                 argb & 0xff);
        }
    }
    public enum TmTechColor
    {
        Approved = 0x38b04a,
        Cancel = 0x455f73,
        Warning = 0xFF4821,
        GridviewRow = 0x90CAF9,
        Waiting = 0xEAFF92,
        Finish = 0x31a8d2,
        InProgress = 0x38b04a
    }
}
