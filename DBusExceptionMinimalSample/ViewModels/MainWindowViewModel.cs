using System.Collections.Generic;
using System.Linq;

namespace DBusExceptionMinimalSample.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        Items = Enumerable.Range(0, 10).Select(i => new Test { TestString = "Value" + i });
    }
    
    public IEnumerable<Test> Items { get; set; }
}

public class Test
{
    public string TestString { get; set; }
}

