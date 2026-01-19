using System.Collections.ObjectModel;

namespace CatalogBooks.VM;

public class MainVM : BaseVM
{
    private ObservableCollection<BookVM> _filteredbooks;
    private ObservableCollection<BookVM> _books;
    private BookVM _selectedBook;
    private string _searchtext;
    
    public ObservableCollection<BookVM> FilterBooks
    {
        get => _filteredbooks;
        set
        {
            if (Equals(value, _filteredbooks)) return;
            _filteredbooks = value;
            OnPropertyChanged();
        }
    }

    public BookVM SelectedBook
    {
        get => _selectedBook;
        set
        {
            if (Equals(value, _selectedBook)) return;
            _selectedBook = value;
            OnPropertyChanged();
        }
    }

    public ObservableCollection<BookVM> Books
    {
        get => _books;
        set
        {
            if (Equals(value, _books)) return;
            _books = value;
            OnPropertyChanged();
        }
    }
    
    public string SearchText
    {
        get => _searchtext;
        set
        {
            if (Equals(value, _searchtext)) return;
            _searchtext = value;
            OnPropertyChanged();
        }
    }
}