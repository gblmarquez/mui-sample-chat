using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace MuiChat.App.ViewModels
{
    public class ShellViewModel : IShellViewModel
    {
    }

    [InheritedExport]
    public interface IShellViewModel
    {

    }
}
