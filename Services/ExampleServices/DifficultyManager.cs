using Attributes;
using UnityEngine;

namespace Services.ExampleServices
{
    [AutoRegisteredService]
    public class DifficultyManager
    {
        private int _difficultyLevel = MinDifficultyLevel;
        private const int MinDifficultyLevel = 1;
        private const int MaxDifficultyLevel = 10;
        
        public void IncreaseDifficulty()
        {
            _difficultyLevel = AdjustDifficultyLevel(_difficultyLevel + 1);
        }

        public void DecreaseDifficulty()
        {
            _difficultyLevel = AdjustDifficultyLevel(_difficultyLevel - 1);
        }

        private static int AdjustDifficultyLevel(int newLevel)
        {
            return Mathf.Clamp(newLevel, MinDifficultyLevel, MaxDifficultyLevel);
        }
    }
}
