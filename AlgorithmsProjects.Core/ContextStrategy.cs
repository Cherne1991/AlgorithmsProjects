namespace AlgorithmsProjects.Core
{
    public class ContextStrategy
    {
        private ISearchStrategy _strategy;

        public ContextStrategy(ISearchStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ISearchStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Execute(IEnumerable<int> list, int item, int low = -1, int high = -1)
        {
            return _strategy.Search(list, item, 0, list.Count() - 1);
        }
    }

    public class ContextStringTypeStrategy
    {
        private ISearchStringTypeStrategy _strategy;

        public ContextStringTypeStrategy(ISearchStringTypeStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(ISearchStringTypeStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Execute(IEnumerable<string> list, string item, int low = -1, int high = -1)
        {
            return _strategy.Search(list, item, 0, list.Count() - 1);
        }
    }
}
