using System;
using System.Text.Json;

namespace DumpClipboard
{
    internal static class ConsoleEx
    {
        public static void WriteJson<T>(T obj)
        {
            Console.WriteLine(JsonSerializer.Serialize(obj, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                IgnoreNullValues = true,
            }));
        }
    }
}