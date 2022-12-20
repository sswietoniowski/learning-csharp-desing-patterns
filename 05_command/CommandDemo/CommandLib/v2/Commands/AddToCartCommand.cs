using CommandLib.v2.Models;
using CommandLib.v2.Repositories;

namespace CommandLib.v2.Commands
{
    public class AddToCartCommand : ICommand
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IProductRepository _productRepository;
        private readonly int _shoppingCartId;
        private readonly Product _product;

        public AddToCartCommand(IShoppingCartRepository shoppingCartRepository, IProductRepository productRepository, int shoppingCartId, Product product)
        {
            _shoppingCartRepository = shoppingCartRepository;
            _productRepository = productRepository;
            _shoppingCartId = shoppingCartId;
            _product = product;
        }

        public void Execute()
        {
            if (_product.Stock == 0)
            {
                throw new InvalidOperationException("Product out of stock");
            }

            _shoppingCartRepository.AddProduct(_shoppingCartId, _product);
            _productRepository.DecreaseStock(_product.Id);
        }

        public bool CanExecute()
        {
            return _shoppingCartRepository.Get(_shoppingCartId) != null;
        }

        public void Undo()
        {
            _shoppingCartRepository.RemoveProduct(_shoppingCartId, _product.Id);
            _productRepository.IncreaseStock(_product.Id);
        }
    }
}
