- You have to write a JavaScript code that prints the longest common substring of passed arguments (with trailing newline — just use console.log for output).
- The code will be running under Node.js and arguments will be passed via command line (you should not read standard input stream).
- If the longest common superstring is empty (no arguments are passed or arguments have no common substrings) it’s necessary to print single newline.
- If there are several solution print any single one of them.
- Limits (do not use them in your solutions, these are only test restrictions): single string length is less or equal to 256, number of strings is less or equal to 64, strings contain only English letter and digits, time limit per test is 5 seconds.
- The output should not contain any excess characters.
- The solution is accepted if all tests are passed. The result is calculated based on JavaScript file size (the smaller the better). So, no comments, no long names, no indents, etc.
- You cannot use any external packages (there is only clean Node.js installation on the server).
- Your solution should be put in the lcs.js file (LCS in the lower case and .js extension).
 You have to use only command-line arguments (no readline, no process.stdin, etc.; ONLY process.argv).
- When called without arguments, your script should not fail.
- If some tests are failed your grade is zero.

# Some examples

```
node lcs.js ABCDEFZ WBCDXYZ
BCD
```

```
node lcs.js 132 12332 12312
1
```

```
node lcs.js ABCDEFGH ABCDEFG ABCEDF ABCED
ABC
```

```
node lcs.js ABCDEFGH ABCDEFG ABCDEF ABCDE
ABCDE
```

```
node lcs.js ABCDEFGH ABCDEFG ABCDEF ABCDE EDCBA
A
```

```
node lcs.js ABCDEFGH ABCDEFG ABCDEF ABCDE EDCBCA
BC
```

```
node lcs.js ABCDEFGH ABCDEFG AxBCDEF ABCDxE EDCBCAABCD
BCD
```

```
node lcs.js ABCDEFGH 1234

```

```
node lcs.js ABCDEFGH
ABCDEFGH
```

# Notes

If you think that test is wrong, check whitespaces in your output — test cannot differentiate spaces and junk output 🙂
Please, check the following string before submitting your solution: ABCQEFDEFGHIJ BCXEFGYZBCDEWEFGHU (e.g. there is common EFGH).
