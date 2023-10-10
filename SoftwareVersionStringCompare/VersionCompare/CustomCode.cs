using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionCompare
{
    public static class CustomCode
    {
        public static int VersionCompare(string version1, string version2)
        {
            // Split the version strings into segments.
            string[] v1 = version1.Split('.');
            string[] v2 = version2.Split('.');

            // Get the length of the segments.
            int len1 = v1.Length;
            int len2 = v2.Length;

            // Get the max length of the segments.
            int maxLen = Math.Max(len1, len2);

            // Loop through the segments.
            for (int i = 0; i < maxLen; i++)
            {
                // Seperate the segments default to zero.
                int num1 = i < len1 ? int.Parse(v1[i]) : 0;
                int num2 = i < len2 ? int.Parse(v2[i]) : 0;

                // Compare the segments
                if (num1 > num2)
                {
                    return 1; // version 1 is greater than version 2
                }
                else if (num1 < num2)
                {
                    return -1; // version 1 is less than version 2 
                }
            }

            return 0; // version 1 is equal to version 2
        }
    }
}
