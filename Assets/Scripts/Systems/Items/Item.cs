using System;
using Interfaces;

namespace Systems.Items
{
    [Serializable]
    public abstract class Item
    {
        public virtual void ApplyItem(IItemHandleable itemHandler){}
    }
}