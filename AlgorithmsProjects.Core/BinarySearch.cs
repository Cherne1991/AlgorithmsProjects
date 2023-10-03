namespace AlgorithmsProjects.Core
{
    public class BinarySearch : ISearchStrategy
    {
        public int Search(IEnumerable<int> list, int item, int low = -1, int high = -1)
        {
            int step = 0;

            while (low <= high)
            {
                step++;

                Console.WriteLine($"Step: {step}");

                var middle = (low + high) / 2;
                var guess = list.ElementAt(middle);

                if (guess == item)
                    return middle;

                if (guess > item)
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }

            return -1;
        }
    }

    public class RecursiveBinarySearch : ISearchStrategy
    {
        public int Search(IEnumerable<int> list, int item, int low, int high)
        {
            if (low > high)
                return -1;

            var middle = (low + high) / 2;
            var guess = list.ElementAt(middle);

            if (guess == item)
                return middle;

            return (guess > item)
                ? Search(list, item, low, middle - 1)
                : Search(list, item, middle + 1, high);
        }
    }

    public class BinaryStringTypeSearch : ISearchStringTypeStrategy
    {
        public int Search(IEnumerable<string> list, string item, int low = -1, int high = -1)
        {
            int step = 0;

            while (low <= high)
            {
                step++;

                Console.WriteLine($"Step: {step}");

                var middle = (low + high) / 2;
                var guess = list.ElementAt(middle);

                if (guess == item)
                    return middle;

                if (guess.Equals(item))
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }

            return -1;
        }
    }
}
