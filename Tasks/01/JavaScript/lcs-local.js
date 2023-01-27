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
    lcs(arrs[a]);
}

function lcs(arr) {
    n = arr.length;

    s = arr[0];
    len = s.length;

    res = "";

    for (i = 0; i < len; i++) {
        for (j = i + 1; j <= len; j++) {
            stem = s.substr(i, j - i);

            for (k = 1; k < n; k++)

                if (!arr[k].includes(stem))
                    break;

            if (k == n && res.length < stem.length)
                res = stem;
        }
    }

    console.log(res);
}