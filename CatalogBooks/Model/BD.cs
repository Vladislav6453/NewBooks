using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using CatalogBooks.VM;

namespace CatalogBooks.Model;

public class BD
{
    private List<Book> _books;
    JsonSerializerOptions opt = new JsonSerializerOptions
    {
        DefaultIgnoreCondition =
            System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        ReferenceHandler = ReferenceHandler.Preserve,
    };
    public void LoadBooks()
    {
        try
        {
            using (var fs = File.OpenRead("books.json"))
            {
                _books = JsonSerializer.Deserialize<List<Book>>(fs, opt);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Нет там нихера!");
            throw;
        }
    }
}