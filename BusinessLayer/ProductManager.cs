using DataAccessLayer;
using Entities;

namespace BusinessLayer
{
    public class ProductManager
    {
        public bool Create(Product product)
        {
            string error = product.ValidateWithMessage();

            if (string.IsNullOrEmpty(error) == false)
                throw new System.Exception(error);

            ProductDataAccess dataAccess = new ProductDataAccess();
            return dataAccess.Insert(product) > 0;
        }

        public int Update(Product product, int productid)
        {
            ProductDataAccess dataAccess = new ProductDataAccess();
            return dataAccess.Update(product, productid);
        }

        public int Delete(Product product, int productid)
        {
            ProductDataAccess productDataAccess = new ProductDataAccess();
            return productDataAccess.Delete(product, productid);
        }
    }
}
