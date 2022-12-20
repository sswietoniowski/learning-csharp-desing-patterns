using CommandLib.v2.Repositories;

namespace CommandLib.v2.Commands
{
    public class IncreaseQuantityCommand : ICommand
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly int _shoppingCartId;
        private readonly int _productId;

        public IncreaseQuantityCommand(IShoppingCartRepository shoppingCartRepository, int shoppingCartId, int productId)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _shoppingCartId = shoppingCartId;
            _productId = productId;
        }

        public void Execute()
        {
            _shoppingCartRepository.IncreaseProductQuantity(_shoppingCartId, _productId);
        }

        public bool CanExecute()
        {
            return _shoppingCartRepository.Get(_shoppingCartId) != null;
        }

        public void Undo()
        {
            _shoppingCartRepository.DecreaseProductQuantity(_shoppingCartId, _productId);
        }
    }
}
