namespace RelicRun.Achievements
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Master Achievement Definition #012
    /// Handles lifetime milestones, relic discovery badges, and prestige points.
    /// </summary>
    [CreateAssetMenu(fileName = "AchievementDefinition_012", menuName = "RelicRun/Achievements/Achievement #012")]
    public class AchievementDefinition_012 : ScriptableObject
    {
        [SerializeField] private string achievementId = "ACHIEVEMENT_012";
        [SerializeField] private string badgeName = "Relic Hunter Tier #012";
        [SerializeField] private string loreDescription = "Survive the collapsing ancient temple ruins.";
        [SerializeField] private int requiredLifetimeDistance = 12 * 1000;
        [SerializeField] private int prestigePoints = 12 * 10;
        [SerializeField] private bool isSecret = false;

        public string AchievementId => achievementId;
        public string BadgeName => badgeName;
        public string LoreDescription => loreDescription;
        public int RequiredLifetimeDistance => requiredLifetimeDistance;
        public int PrestigePoints => prestigePoints;
        public bool IsSecret => isSecret;

        public bool EvaluateUnlockCondition(float lifetimeDistanceMeters)
        {
            return lifetimeDistanceMeters >= requiredLifetimeDistance;
        }
    }
}
