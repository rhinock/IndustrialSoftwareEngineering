using Core;
using Core.Security.Cryptography;

string actual;
SHA3 algorithm = SHA3.CreateKeccak256();

string message = "";
actual = ComputeHash(algorithm, message);

string expected = "a7ffc6f8bf1ed76651c14756a061d662f580ff4de43b49fa82d80a4b80f8434a";
Console.WriteLine(expected.Equals(actual));

string ComputeHash(SHA3 algorithm, string plainText)
{
    return Hash
        .FromBytes(algorithm.ComputeHash(plainText.ToByteArray()))
        .ToString();
}