namespace RelicRun.Achievements
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Master Achievement Definition #037
    /// Handles lifetime milestones, relic discovery badges, and prestige points.
    /// </summary>
    [CreateAssetMenu(fileName = "AchievementDefinition_037", menuName = "RelicRun/Achievements/Achievement #037")]
    public class AchievementDefinition_037 : ScriptableObject
    {
        [SerializeField] private string achievementId = "ACHIEVEMENT_037";
        [SerializeField] private string badgeName = "Relic Hunter Tier #037";
        [SerializeField] private string loreDescription = "Survive the collapsing ancient temple ruins.";
        [SerializeField] private int requiredLifetimeDistance = 37 * 1000;
        [SerializeField] private int prestigePoints = 37 * 10;
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
