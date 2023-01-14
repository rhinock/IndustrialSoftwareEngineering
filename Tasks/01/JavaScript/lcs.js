const { argv } = require('node:process');

if (argv.length <= 2) {
    console.log();
}
else if (argv.length == 3) {
    console.log(argv[2]);
}
else {
    arr = argv.slice(2);
    lcs(arr);
}

function lcs(arr) {
    n = arr.length;
    s = arr[0];
    len = s.length;
    res = "";

    for (i = 0; i < len; i++) {
        for (j = i + 1; j <= len; j++) {
            stem = s.substring(i, j - i);
            k = 1;

            for (k = 1; k < n; k++)
                if (!arr[k].includes(stem))
                    break;

            if (k == n && res.length < stem.length)
                res = stem;
        }
    }

    console.log(res);
}