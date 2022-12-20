using CommandLib.v2.Repositories;

namespace CommandLib.v2.Commands
{
    public class ChangeQuantityCommand : ICommand
    {
        private readonly Operation _operation;
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly ProductRepository _productRepository;
        private readonly int _shoppingCartId;
        private readonly int _productId;

        public ChangeQuantityCommand(Operation operation, IShoppingCartRepository shoppingCartRepository, ProductRepository productRepository, int shoppingCartId, int productId)
        {
            _operation = operation;
            _shoppingCartRepository = shoppingCartRepository;
            _productRepository = productRepository;
            _shoppingCartId = shoppingCartId;
            _productId = productId;
        }

        public void Execute()
        {
            if (_operation == Operation.Increase)
            {
                _shoppingCartRepository.IncreaseProductQuantity(_shoppingCartId, _productId);
                _productRepository.DecreaseStock(_productId);
            }
            else
            {
                _shoppingCartRepository.DecreaseProductQuantity(_shoppingCartId, _productId);
                _productRepository.IncreaseStock(_productId);
            }
        }

        public bool CanExecute()
        {
            return _shoppingCartRepository.Get(_shoppingCartId) != null;
        }

        public void Undo()
        {
            if (_operation == Operation.Increase)
            {
                _shoppingCartRepository.DecreaseProductQuantity(_shoppingCartId, _productId);
                _productRepository.IncreaseStock(_productId);
            }
            else
            {
                _shoppingCartRepository.IncreaseProductQuantity(_shoppingCartId, _productId);
                _productRepository.DecreaseStock(_productId);
            }
        }
    }
}
