using SHA3.Net;
using SHA3.Net.Tests;
using System.Text;

List<string> hashes = new List<string>();

foreach (string file in Directory.EnumerateFiles("task2"))
{
    using FileStream fileStream = File.OpenRead(file);
    var hash = Sha3.Sha3256().ComputeHash(fileStream).ToHexString().ToLower();

    if (hash is null)
        throw new Exception();

    hashes.Add(hash);
}

hashes.Sort();

var hashesString = string.Join(string.Empty, hashes);
hashesString += "rhinock@yandex.ru";

var resultHash = Sha3.Sha3256().ComputeHash(Encoding.ASCII.GetBytes(hashesString)).ToHexString().ToLower();
Console.WriteLine(resultHash);
