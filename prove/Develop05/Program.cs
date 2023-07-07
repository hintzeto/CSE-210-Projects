using System;
using System.Text.Json;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        JsonWriterOptions writerOptions = new() {Indented = true,};

        using MemoryStream stream = new();
        using Utf8JsonWriter writer = new(stream, writerOptions);

        writer.WriteStartObject();
        writer.WriteStartArray("This is an array name");
        writer.WriteStartObject();
        writer.WritePropertyName("Property name");
        writer.WriteNumberValue(1);
        writer.WriteEndObject();
        writer.WriteEndArray();
        writer.WriteEndObject();
        writer.Flush();
        
        string json = Encoding.UTF8.GetString(stream.ToArray());

        Console.WriteLine(json);


        // Menu menu = new Menu("Talon");
        // menu.DisplayMenu();


    }
}