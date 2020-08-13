public class Sample
{
    public int Add(params int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum = sum + i;
        }
        return sum;
    }
}


