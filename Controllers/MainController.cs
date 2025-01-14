using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManagement.Views;

namespace VideoGameManagement.Controllers;

internal class MainController
{
    MainView _view = new();
    public void Help()
    {
        _view.HelpView();
    }
    public void Clear()
    {
        _view.ClearView();
    }
    public void Error()
    {
        _view.ErrorView();
    }
    public void Delete()
    {
        _view.DeleteView();
    }
}
