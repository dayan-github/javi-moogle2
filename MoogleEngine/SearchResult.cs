namespace MoogleEngine;

public class SearchResult
{
    private IEnumerable<SearchItem> items;

    public SearchResult(IEnumerable<SearchItem> items, string suggestion="")
    {
        if (items == null) {
            throw new ArgumentNullException(nameof(items));
        }

        this.items = items;
        this.Suggestion = suggestion;
    }

    public SearchResult() : this(new SearchItem[0]) {

    }

    public string Suggestion { get; private set; }

    public IEnumerable<SearchItem> Items() {
        return this.items;
    }

    public int Count { get { return this.items.Count(); } }

    public string[] DocumentNames;
    public SortedDictionary<string, List<int>> Vocabulary;
    public Dictionary<string, List<double>> TFMatrix;
    public Dictionary<string, double> IDFMatrix;
    public Dictionary<string, List<double>> TFIDFMatrix;
}
