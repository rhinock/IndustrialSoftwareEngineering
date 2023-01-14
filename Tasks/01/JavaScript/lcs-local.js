arrs = [
    ["ABCDEFZ", "WBCDXYZ"],
    ["132", "12332", "12312"],
    ["ABCDEFGH", "ABCDEFG", "ABCEDF", "ABCED"],
    ["ABCDEFGH", "ABCDEFG", "ABCDEF", "ABCDE"],
    ["ABCDEFGH", "ABCDEFG", "ABCDEF", "ABCDE", "EDCBA"],
    ["ABCDEFGH", "ABCDEFG", "ABCDEF", "ABCDE", "EDCBCA"],
    ["ABCDEFGH", "ABCDEFG", "AxBCDEF", "ABCDxE", "EDCBCAABCD"],
    ["ABCDEFGH", "1234"],
    ["ABCDEFGH"],
    ["ABCQEFDEFGHIJ", "BCXEFGYZBCDEWEFGHU"]
];

answers = ["BCD", "1", "ABC", "ABCDE", "A", "BC", "BCD", "", "ABCDEFGH", "EFGH"];

for (a = 0; a < answers.length; a++) {
    // Function call
    lcs(arrs[a]);
}

function lcs(arr) {
    // Determine size of the array
    n = arr.length;

    // Take first word from array as reference
    s = arr[0];
    len = s.length;

    res = "";

    for (i = 0; i < len; i++) {
        for (j = i + 1; j <= len; j++) {
            // generating all possible substrings
            // of our reference string arr[0] i.e s
            stem = s.substr(i, j - i);

            for (k = 1; k < n; k++)

                // Check if the generated stem is
                // common to all words
                if (!arr[k].includes(stem))
                    break;

            // If current substring is present in
            // all strings and its length is greater
            // than current result
            if (k == n && res.length < stem.length)
                res = stem;
        }
    }

    console.log(res);
}