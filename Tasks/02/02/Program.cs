using Core;
using Core.Security.Cryptography;

SHA3 algorithm = SHA3.CreateKeccak256();
List<string> hashes = new List<string>();

foreach (string file in Directory.EnumerateFiles("task2"))
{
    using FileStream fileStream = File.OpenRead(file);
    var hash = Hash.FromBytes(algorithm.ComputeHash(fileStream)).ToString()?.ToLower();
    
    if (hash is null)
        throw new Exception();
        
    hashes.Add(hash);
}

hashes.Sort();

var hashesString = string.Join(string.Empty, hashes);
hashesString += SecretAppsettingReader.ReadSection<string, Program>("Email");

var resultHash = Hash.FromBytes(algorithm.ComputeHash(hashesString.ToByteArray())).ToString()?.ToLower();
Console.WriteLine(resultHash);