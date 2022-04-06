using Attributes;

namespace Services.ExampleServices
{
    [AutoRegisteredService]
    public class EnemyManager : MonoServiceBase
    {
        public override void Restart()
        {
            throw new System.NotImplementedException();
        }

        public override void Enable()
        {
            throw new System.NotImplementedException();
        }

        public override void Disable()
        {
            throw new System.NotImplementedException();
        }
    }
}
