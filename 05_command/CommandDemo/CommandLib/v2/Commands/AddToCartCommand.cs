using CommandLib.v2.Repositories;
using CommandLib.v2.Models;

namespace CommandLib.v2.Commands
{
    public class AddToCartCommand : ICommand
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly int _shoppingCartId;
        private readonly Product _product;

        public AddToCartCommand(IShoppingCartRepository shoppingCartRepository, int shoppingCartId, Product product)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _shoppingCartId = shoppingCartId;
            _product = product;
        }

        public void Execute()
        {
            _shoppingCartRepository.AddProduct(_shoppingCartId, _product);
        }

        public bool CanExecute()
        {
            return _shoppingCartRepository.Get(_shoppingCartId) != null;
        }

        public void Undo()
        {
            _shoppingCartRepository.RemoveProduct(_shoppingCartId, _product.Id);
        }
    }
}
