using System.Security.Cryptography.X509Certificates;

namespace Vending
{
    public interface IMachine
    {
        int ShowList();
        int ShowPrice(int price);
        void TakeResult(int product, int changeMoney);
    }
}