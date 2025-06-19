using Manage.Core.Services;
using System;
using System.Threading.Tasks;

namespace Manage.Services
{
    public class NavigationService : INavigationService
    {
        private readonly Func<Type, object> _viewModelFactory;

        public NavigationService(Func<Type, object> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }
        public object CurrentViewModel { get; private set; } = null!;

        public event Action<object>? ViewModelChanged;

        public async Task NavigateToAsync<TViewModel>() where TViewModel : class
        {
            await NavigateToAsync(typeof(TViewModel));
        }

        public async Task NavigateToAsync(Type viewModelType)
        {
            var viewModel = _viewModelFactory(viewModelType);
            CurrentViewModel = viewModel;
            ViewModelChanged?.Invoke(viewModel);

            // Optional: run lifecycle hook if available
            if (viewModel is INavigable navigable)
            {
                await navigable.OnNavigatedToAsync();
            }
        }
    }
}
