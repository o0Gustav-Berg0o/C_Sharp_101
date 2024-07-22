public static int[,] GenereraTerräng(int bredd, int höjd, int minHöjd, int maxHöjd)
{
    Random random = new Random();
    int[,] terräng = new int[bredd, höjd];

    for (int x = 0; x < bredd; x++)
    {
        for (int y = 0; y < höjd; y++)
        {
            terräng[x, y] = random.Next(minHöjd, maxHöjd + 1);
        }
    }

    return terräng;
}