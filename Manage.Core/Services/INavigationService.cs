using System;
using System.Threading.Tasks;

namespace Manage.Core.Services
{
    public interface INavigationService
    {
        object CurrentViewModel { get; }
        Task NavigateToAsync<TViewModel>() where TViewModel : class;
        Task NavigateToAsync(Type viewModelType);
    }
}
