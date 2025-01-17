using System;

class Program
{
    static void Main(string[] args)
    {
        Uri info = new Uri("http://www.domain.com:80/info?id=123#fragment");
        Uri page = new Uri("http://www.domain.com/info/page.html");

        Console.WriteLine($"Host: {info.Host}");
        Console.WriteLine($"Port: {info.Port}");
        Console.WriteLine($"PathAndQuery: {info.PathAndQuery}");
        Console.WriteLine($"Query: {info.Query}");
        Console.WriteLine($"Fragment: {info.Fragment}");
        Console.WriteLine($"Default HTTP port: {page.Port}");
        Console.WriteLine($"IsBaseOf: {info.IsBaseOf(page)}");

        Uri relative = info.MakeRelativeUri(page);
        Console.WriteLine($"IsAbsoluteUri: {relative.IsAbsoluteUri}");
        Console.WriteLine($"RelativeUri: {relative.ToString()}");

        Console.ReadLine();
    }
}
