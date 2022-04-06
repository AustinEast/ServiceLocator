using UnityEngine;

namespace Services.ExampleServices
{
    public class ConsoleWriterService
    {
        private int _messageIndex;

        public void Log(string msg)
        {
            var msgId = _messageIndex.ToString().PadLeft(5, '0');
            Debug.Log($"Msg #{msgId}: {msg}");
            _messageIndex += 1;
        }
    }
}
