

using LuisManager.Domain;

namespace LuisManager.Common.Contracts
{
    public interface IDataProvider
    {
        Product[] GetData();
        void SetData(Product[] products);
    }
}
