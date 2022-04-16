namespace C_Sharp.ShuffleString
{
    public class Solution
    {
        public string RestoreString(string s, int[] indices)
        {
            char[] chars = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                chars[indices[i]] = s[i];
            }

            return new string(chars);
        }
    }
}
