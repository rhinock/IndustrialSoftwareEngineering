String[][] arrs = new String[][] {
    new String[] {"ABCDEFZ", "WBCDXYZ"},
    new String[] {"132", "12332", "12312"},
    new String[] {"ABCDEFGH", "ABCDEFG", "ABCEDF", "ABCED"},
    new String[] {"ABCDEFGH", "ABCDEFG", "ABCDEF", "ABCDE"},
    new String[] {"ABCDEFGH", "ABCDEFG", "ABCDEF", "ABCDE", "EDCBA"},
    new String[] {"ABCDEFGH", "ABCDEFG", "ABCDEF", "ABCDE", "EDCBCA"},
    new String[] {"ABCDEFGH", "ABCDEFG", "AxBCDEF", "ABCDxE", "EDCBCAABCD"},
    new String[] {"ABCDEFGH", "1234"},
    new String[] {"ABCDEFGH"},
    new String[] {"ABCQEFDEFGHIJ", "BCXEFGYZBCDEWEFGHU"}
};

String[] answers = new String[] 
{
    "BCD", 
    "1", 
    "ABC", 
    "ABCDE", 
    "A", 
    "BC", 
    "BCD", 
    "", 
    "ABCDEFGH",
    "EFGH"
    };

for (int i = 0; i < arrs.GetLength(0); i++)
{
    String stems = FindStem(arrs[i]);
    Console.WriteLine($"{stems} == {answers[i]}");
}

static String FindStem(String[] arr)
{
    int n = arr.Length;

    String s = arr[0];
    int len = s.Length;

    String res = "";

    for (int i = 0; i < len; i++)
    {
        for (int j = i + 1; j <= len; j++)
        {
            String stem = s.Substring(i, j - i);
            int k = 1;
            for (k = 1; k < n; k++)

                if (!arr[k].Contains(stem))
                    break;

            if (k == n && res.Length < stem.Length)
                res = stem;
        }
    }

    return res;
}