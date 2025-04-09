public class RandomizedSet {

    private Dictionary<int, int> valToIndex;
    private List<int> values;
    private Random random;

    public RandomizedSet() {
        valToIndex = new Dictionary<int, int>();
        values = new List<int>();
        random = new Random();
    }

    public bool Insert(int val) {
        if (valToIndex.ContainsKey(val)) return false;

        values.Add(val);
        valToIndex[val] = values.Count - 1;
        return true;
    }

    public bool Remove(int val) {
        if (!valToIndex.ContainsKey(val)) return false;

        int index = valToIndex[val];
        int lastElement = values[^1];

        values[index] = lastElement;
        valToIndex[lastElement] = index;

        values.RemoveAt(values.Count - 1);
        valToIndex.Remove(val);

        return true;
    }

    public int GetRandom() {
        int randIndex = random.Next(values.Count);
        return values[randIndex];
    }
}
