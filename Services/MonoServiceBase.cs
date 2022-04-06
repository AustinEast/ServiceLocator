using UnityEngine;

namespace Services
{
    public abstract class MonoServiceBase : MonoBehaviour, IServiceBase
    {
        protected void Reset()
        {
            name = GetType().Name;
        }
        
        public abstract void Restart();
        public abstract void Enable();
        public abstract void Disable();
    }
}
