using CatalogBooks.Model;

namespace CatalogBooks.VM;

public class BookVM : BaseVM
{
    private readonly Book _book;
    
    public string Title
    {
        get => _book.Title;
        set
        {
            _book.Title = value;
            OnPropertyChanged();
            OnPropertyChanged();
        }
    }
    
    public string Isbn
    {
        get => _book.Isbn;
        set
        {
            _book.Isbn = value;
            OnPropertyChanged();
        }
    }
    
    public string Author
    {
        get => _book.Author;
        set
        {
            _book.Author = value;
            OnPropertyChanged();
        }
    }
    
    public int Year
    {
        get => _book.Year;
        set
        {
            _book.Year = value;
            OnPropertyChanged();
        }
    }
}