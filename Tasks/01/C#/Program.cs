String[][] arrs = new String[][] {
    new String[] {"ABCDEFZ", "WBCDXYZ"},
    new String[] {"132", "12332", "12312"},
    new String[] {"ABCDEFGH", "ABCDEFG", "ABCEDF", "ABCED"},
    new String[] {"ABCDEFGH", "ABCDEFG", "ABCDEF", "ABCDE"},
    new String[] {"ABCDEFGH", "ABCDEFG", "ABCDEF", "ABCDE", "EDCBA"},
    new String[] {"ABCDEFGH", "ABCDEFG", "ABCDEF", "ABCDE", "EDCBCA"},
    new String[] {"ABCDEFGH", "ABCDEFG", "AxBCDEF", "ABCDxE", "EDCBCAABCD"},
    new String[] {"ABCDEFGH", "1234"},
    new String[] {"ABCDEFGH"}
};

String[] answers = new String[] {"BCD", "1", "ABC", "ABCDE", "A", "BC", "BCD", "", "ABCDEFGH"};

for (int i = 0; i < arrs.GetLength(0); i++)
{
    // Function call
    String stems = FindStem(arrs[i]);
    Console.WriteLine($"{stems} == {answers[i]}");
}

// function to find the stem (longest common substring) from the string array
static String FindStem(String[] arr)
{
    // Determine size of the array
    int n = arr.Length;

    // Take first word from array as reference
    String s = arr[0];
    int len = s.Length;

    String res = "";

    for (int i = 0; i < len; i++)
    {
        for (int j = i + 1; j <= len; j++)
        {
            // generating all possible substrings
            // of our reference string arr[0] i.e s
            String stem = s.Substring(i, j - i);
            int k = 1;
            for (k = 1; k < n; k++)

                // Check if the generated stem is
                // common to all words
                if (!arr[k].Contains(stem))
                    break;

            // If current substring is present in
            // all strings and its length is greater
            // than current result
            if (k == n && res.Length < stem.Length)
                res = stem;
        }
    }

    return res;
}