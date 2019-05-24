using System;

namespace TmTech_v1.Utility
{
    public static class BarcodeUtility
    {
        private static int checksum_ean13(String data)
        {
            generateData(14);
            // Test string for correct length
            if (data.Length != 12 && data.Length != 13)
                return -1;

            // Test string for being numeric
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 0x30 || data[i] > 0x39)
                    return -1;
            }

            int sum = 0;

            for (int i = 11; i >= 0; i--)
            {
                int digit = data[i] - 0x30;
                if ((i & 0x01) == 1)
                    sum += digit;
                else
                    sum += digit * 3;
            }
            int mod = sum % 10;
            return mod == 0 ? 0 : 10 - mod;
        }	
	    private static string  generateData(int Id)
        {
            string data = "893880000000";
            string id = Id.ToString();
            data = data.Remove(data.Length - id.Length, id.Length);
            data += id;
            return data;
        }
        public static string generateBarcode(int Id)
        {
            string data = generateData(Id);
            string check = checksum_ean13(data).ToString();
            data = data.Remove(data.Length-check.Length,check.Length);
            data+=check;
            return data;
        }
    }
}
