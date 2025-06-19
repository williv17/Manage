using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage.Core.Services
{
    public interface INavigable
    {
        Task OnNavigatedToAsync();
    }
}
