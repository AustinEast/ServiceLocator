using UnityEngine;

namespace Services.Examples.ExampleServices
{
    /*
     * Marking regular class as IRegistrable allows to register it in the ServiceLocator manually.
     * The ServiceLocator.Register(s) where s is the service, requires s to be IRegistrable.
     * The service does not have to be of MonoBehaviour class.
     */
    public class RegularClassService : IRegistrable
    {
        
        public void Work()
        {
            Debug.Log($"{GetType().Name} is performing action.");
        }
    }
}
