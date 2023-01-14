// const { argv } = require('node:process');

// if (argv.length <= 2) {
//     console.log();
// }

// if (argv.length == 3) {
//     console.log(argv[2]);
// }

arrs = [
    ["ABCDEFZ", "WBCDXYZ"],
    ["132", "12332", "12312"],
    ["ABCDEFGH", "ABCDEFG", "ABCEDF", "ABCED"],
    ["ABCDEFGH", "ABCDEFG", "ABCDEF", "ABCDE"],
    ["ABCDEFGH", "ABCDEFG", "ABCDEF", "ABCDE", "EDCBA"],
    ["ABCDEFGH", "ABCDEFG", "ABCDEF", "ABCDE", "EDCBCA"],
    ["ABCDEFGH", "ABCDEFG", "AxBCDEF", "ABCDxE", "EDCBCAABCD"],
    ["ABCDEFGH", "1234"],
    ["ABCDEFGH"]
];

answers = ["BCD", "1", "ABC", "ABCDE", "A", "BC", "BCD", "", "ABCDEFGH"];

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
            stem = s.substring(i, j - i);
            k = 1;
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