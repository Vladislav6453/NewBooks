using System.Collections.ObjectModel;
using System.Linq;

namespace CatalogBooks.VM;

public class MainVM : BaseVM
{
    private ObservableCollection<BookVM> _filteredbooks;
    private ObservableCollection<BookVM> _books;
    private BookVM _selectedBook;
    private string _searchtext;
    private bool _isSearching;

    public ObservableCollection<BookVM> FilteredBooks
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
            if (SearchText != value)
            {
                _searchtext = value;
                OnPropertyChanged();
                Filter();
            }
        }
    }

    public bool IsSearching
    {
        get => _isSearching;
        set
        {
            if (value == _isSearching) return;
            _isSearching = value;
            OnPropertyChanged();
        }
    }
    
    
    public MainVM()
    {
        
        
         Filter();
    }

    private void Filter()
    {
        if (string.IsNullOrEmpty(SearchText))
        {
            FilteredBooks = new ObservableCollection<BookVM>(Books);
            IsSearching =  false;
        }
        else
        {
            var SearchTextLower = SearchText.ToLower();
            var Filtered = Books.Where(b=>b.Title.ToLower().Contains(SearchTextLower)).ToList();
            FilteredBooks = new ObservableCollection<BookVM>(Filtered);
            IsSearching = true;
        }
    }
}

