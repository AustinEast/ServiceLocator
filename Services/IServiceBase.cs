namespace Services
{
    public interface IServiceBase
    {
        public void Restart();
        public void Enable();
        public void Disable();
    }
}
