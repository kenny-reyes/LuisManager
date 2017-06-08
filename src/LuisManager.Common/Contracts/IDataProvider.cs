

using LuisManager.Domain;

namespace LuisManager.Common.Contracts
{
    public interface IDataProvider
    {
        LuisScheme GetData();
        void SetData(LuisScheme luisSchemes);
    }
}
