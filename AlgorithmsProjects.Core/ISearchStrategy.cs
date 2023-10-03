namespace AlgorithmsProjects.Core
{
    public interface ISearchStrategy
    {
        int Search(IEnumerable<int> list, int item, int low = -1, int high = -1);
    }

    public interface ISearchStringTypeStrategy
    {
        int Search(IEnumerable<string> list, string item, int low = -1, int high = -1);
    }

    //public interface ISearchStrategy : IStrategy
    //{
    //    int Search(IEnumerable<int> list, int item);
    //}

    //public interface IRecursiveSearchStrategy : IStrategy
    //{
    //    int Search(IEnumerable<int> list, int item, int low, int high);
    //}
}