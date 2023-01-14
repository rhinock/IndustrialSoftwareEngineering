Task #2 (ALL GROUPS)

Language: either JavaScript or TypeScript or Java or C# or Python or Ruby or anything you like.
Calculate SHA3-256 for every file from archive. Note, files are binary, you don’t need encodings — if you read file to string with some encoding, you have to use the same encoding to decode string into bytes for hashing (there is a technical term for such conversions “stupid activity”).
Write hashes as 64 hex digits in lower case.
Sort hashes as strings.
Join sorted hashes without any separator.
Concatenate resulted string with your e-mail in lowercase.
Find the SHA3-256 of the result string.
Send obtained 64 hex digits in the lower case to ilearning.task2@gmail.com.
Note: SHA3-256 is not the same algorithm as SHA-256. 

Some additional hints (based on the experience of previous groups): check if you use SHA3-256, check if you process exactly 256 required files (not everything in the some directory), check if you concatenate your strings without separator — beware of JavaScript's join! — check if you write e-mail in lower case and send e-mail from the same address you used in code. And, of course, you have to calculate separate hash for every file, not to update the same hash with every file.