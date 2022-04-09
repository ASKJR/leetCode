namespace C_Sharp.CanPlaceFlowers
{
    public class Solution
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int canPlaceFlowers = 0;

            if (n == 0) return true;
            if (flowerbed.Length == 1 && flowerbed[0] == 0) return true;
            if (flowerbed.Length == 1 && flowerbed[0] == 1) return false;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (i == 0 && flowerbed[i + 1] == 0 && flowerbed[i] == 0)
                {
                    ++canPlaceFlowers;
                    flowerbed[i] = 1;
                }
                else if (i == (flowerbed.Length - 1) && flowerbed[i - 1] == 0 && flowerbed[i] == 0)
                {
                    ++canPlaceFlowers;
                    flowerbed[i] = 1;
                }
                else if(flowerbed.Length > 2 && i != (flowerbed.Length - 1))
                {
                    if (flowerbed[i] == 0 && flowerbed[i + 1] == 0 && flowerbed[i - 1] == 0)
                    {
                        ++canPlaceFlowers;
                        flowerbed[i] = 1;
                    }
                }
            }

            return canPlaceFlowers >= n;
        }
    }
}
