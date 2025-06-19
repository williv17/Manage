using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage.UI.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        public string WelcomeMessage => "Welcome to the Manager App!";
    }
}
