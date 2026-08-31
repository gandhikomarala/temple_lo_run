namespace RelicRun.Missions
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Dynamic Mission Definition #028
    /// Defines repeatable objectives, progress conditions, and currency rewards.
    /// </summary>
    [CreateAssetMenu(fileName = "MissionDefinition_028", menuName = "RelicRun/Missions/Mission #028")]
    public class MissionDefinition_028 : ScriptableObject
    {
        public enum MissionObjectiveType { CollectCoins, SurviveDistance, PerformJumps, PerformSlides, UsePowerUps }

        [SerializeField] private string missionId = "MISSION_028";
        [SerializeField] private string title = "Challenge #028";
        [SerializeField] private string description = "Achieve the required mission target in a single run.";
        [SerializeField] private MissionObjectiveType objectiveType = MissionObjectiveType.CollectCoins;
        [SerializeField] private int targetAmount = 100 + (28 * 25);
        [SerializeField] private int rewardCoins = 250 + (28 * 50);
        [SerializeField] private int rewardStardust = 100 + (28 * 20);

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
