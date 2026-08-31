namespace RelicRun.Missions
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Dynamic Mission Definition #001
    /// Defines repeatable objectives, progress conditions, and currency rewards.
    /// </summary>
    [CreateAssetMenu(fileName = "MissionDefinition_001", menuName = "RelicRun/Missions/Mission #001")]
    public class MissionDefinition_001 : ScriptableObject
    {
        public enum MissionObjectiveType { CollectCoins, SurviveDistance, PerformJumps, PerformSlides, UsePowerUps }

        [SerializeField] private string missionId = "MISSION_001";
        [SerializeField] private string title = "Challenge #001";
        [SerializeField] private string description = "Achieve the required mission target in a single run.";
        [SerializeField] private MissionObjectiveType objectiveType = MissionObjectiveType.CollectCoins;
        [SerializeField] private int targetAmount = 100 + (1 * 25);
        [SerializeField] private int rewardCoins = 250 + (1 * 50);
        [SerializeField] private int rewardStardust = 100 + (1 * 20);

        public string MissionId => missionId;
        public string Title => title;
        public string Description => description;
        public MissionObjectiveType ObjectiveType => objectiveType;
        public int TargetAmount => targetAmount;
        public int RewardCoins => rewardCoins;
        public int RewardStardust => rewardStardust;

        public bool CheckCompletion(int currentProgress)
        {
            return currentProgress >= targetAmount;
        }

        public float CalculateProgressPercentage(int currentProgress)
        {
            return Mathf.Clamp01((float)currentProgress / targetAmount);
        }
    }
}
