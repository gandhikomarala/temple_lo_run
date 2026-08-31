namespace RelicRun.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cosmetic Skin & Character Wardrobe Definition #025
    /// Handles custom character outfits, particle trail effects, and unlock requirements.
    /// </summary>
    [CreateAssetMenu(fileName = "CosmeticSkinDefinition_025", menuName = "RelicRun/Cosmetics/Skin #025")]
    public class CosmeticSkinDefinition_025 : ScriptableObject
    {
        public enum RarityTier { Common, Rare, Epic, Legendary, Mythic }

        [Header("Skin Identity")]
        [SerializeField] private string skinId = "SKIN_025";
        [SerializeField] private string outfitName = "Adventurer Outfit #025";
        [SerializeField] private RarityTier rarity = RarityTier.Rare;
        [SerializeField] private Color auraTrailColor = new Color(0.2f, 0.6f, 1.0f, 0.8f);

        [Header("Unlock Progression")]
        [SerializeField] private int requiredRelicCoins = 500 + (25 * 50);
        [SerializeField] private int requiredDistanceMeters = 25 * 800;
        [SerializeField] private bool isUnlockedByDefault = false;

        public string SkinId => skinId;
        public string OutfitName => outfitName;
        public RarityTier Rarity => rarity;
        public Color AuraTrailColor => auraTrailColor;
        public int RequiredRelicCoins => requiredRelicCoins;
        public int RequiredDistanceMeters => requiredDistanceMeters;
        public bool IsUnlockedByDefault => isUnlockedByDefault;

        public bool CanUnlock(int playerCoins, float playerLifetimeDistance)
        {
            return playerCoins >= requiredRelicCoins && playerLifetimeDistance >= requiredDistanceMeters;
        }

        public float GetAuraIntensityMultiplier()
        {
            return rarity switch
            {
                RarityTier.Common => 1.0f,
                RarityTier.Rare => 1.25f,
                RarityTier.Epic => 1.5f,
                RarityTier.Legendary => 2.0f,
                RarityTier.Mythic => 2.5f,
                _ => 1.0f
            };
        }
    }
}
