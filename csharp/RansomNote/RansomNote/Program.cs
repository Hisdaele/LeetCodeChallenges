bool CanConstruct(string ransomNote, string magazine)
{
    var countLetters = new Dictionary<char, int>();
    foreach (char c in magazine)
    {
        int count;
        if (countLetters.TryGetValue(c, out count))
        {
            countLetters[c] = count + 1;
        }
        else
        {
            countLetters.Add(c, count + 1);
        }
    }
    foreach (char c in ransomNote)
    {
        int count;
        if (countLetters.TryGetValue(c, out count))
        {
            if (count == 0)
            {
                return false;
            }
            countLetters[c] = count - 1;
        }
        else
        {
            return false;
        }
    }
    return true;
}
