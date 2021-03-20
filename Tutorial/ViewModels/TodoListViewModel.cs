using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.Models;
using System.Collections.ObjectModel;

namespace Tutorial.ViewModels
{
    class TodoListViewModel : ViewModelBase
    {
        public ObservableCollection<TodoItem> Items { get; }
        public TodoListViewModel(IEnumerable<TodoItem> items)
        {
            Items = new ObservableCollection<TodoItem>(items);
        }
    }
}
