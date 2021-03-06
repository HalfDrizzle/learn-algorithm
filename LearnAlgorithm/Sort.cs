namespace LearnAlgorithm
{
    public class Sort
    {
        public void InsertionSort(int[] a, int n)
        {
            if (n <= 1)
            {
                return;
            }

            for (int i = 1; i < n; i++)
            {
                int value = a[i];
                int j = i - 1;
                for (; j >= 0; j--)
                {
                    if (a[j] > value)
                    {
                        a[j + 1] = a[j];
                    }
                    else
                    {
                        break;
                    }
                }

                a[j + 1] = value;
            }
        }
    }
}