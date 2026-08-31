namespace RelicRun.World
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// Biome Definition & Environmental Ruleset #056
    /// Controls atmospheric fog, dynamic lighting presets, obstacle weights, and ambient audio loops.
    /// </summary>
    [CreateAssetMenu(fileName = "BiomeDefinition_056", menuName = "RelicRun/World/Biome Definition #056")]
    public class BiomeDefinition_056 : ScriptableObject
    {
        [Header("Biome Identity")]
        [SerializeField] private string biomeId = "BIOME_056";
        [SerializeField] private string displayName = "Biome Zone #056";
        [SerializeField] private Color skyColor = new Color(0.1f, 0.2f, 0.35f, 1.0f);
        [SerializeField] private Color fogColor = new Color(0.08f, 0.15f, 0.25f, 1.0f);
        [SerializeField] private float fogDensity = 0.015f;

        [Header("Difficulty Modifiers")]
        [SerializeField] private float obstacleDensityMultiplier = 1.0f + (56 * 0.01f);
        [SerializeField] private float speedMultiplier = 1.0f + (56 * 0.005f);
        [SerializeField] private int minMetersToUnlock = 56 * 500;

        public string BiomeId => biomeId;
        public string DisplayName => displayName;
        public Color SkyColor => skyColor;
        public Color FogColor => fogColor;
        public float FogDensity => fogDensity;
        public float ObstacleDensityMultiplier => obstacleDensityMultiplier;
        public float SpeedMultiplier => speedMultiplier;
        public int MinMetersToUnlock => minMetersToUnlock;

        public bool IsEligibleForDistance(float currentDistanceMeters)
        {
            return currentDistanceMeters >= minMetersToUnlock;
        }

        public float EvaluateTrackHazardIntensity(float baseHazardRate)
        {
            return baseHazardRate * obstacleDensityMultiplier;
        }
    }
}
