namespace RelicRun.PowerUps
{
    using UnityEngine;

    /// <summary>
    /// Power-Up Modifier Unit #090
    /// Handles Coin Magnet, Aegis Shield, 2x Score Multiplier, and Relic Speed Boost.
    /// </summary>
    public class PowerUpModifier_090 : MonoBehaviour
    {
        public enum PowerUpType { CoinMagnet, AegisShield, ScoreMultiplier, SpeedBoost, RelicFrenzy }

        [SerializeField] private PowerUpType type = PowerUpType.CoinMagnet;
        [SerializeField] private float durationSeconds = 10.0f;
        [SerializeField] private float intensityMultiplier = 2.0f;
    }
}
