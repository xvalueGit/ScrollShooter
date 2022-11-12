using Systems.Items;
using Systems.PowerUp;

namespace Interfaces
{
    public interface ICollectable
    {
        public void Collect(out Item item);
    }
}