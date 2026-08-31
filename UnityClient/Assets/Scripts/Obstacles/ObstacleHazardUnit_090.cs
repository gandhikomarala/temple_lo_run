namespace RelicRun.Obstacles
{
    using UnityEngine;

    /// <summary>
    /// Obstacle Hazard Unit #090
    /// Categorized hazard handling static barriers, low slide hurdles, and rotating stone saws.
    /// </summary>
    public class ObstacleHazardUnit_090 : MonoBehaviour
    {
        public enum HazardType { StaticBarrier, JumpHurdle, SlideTrap, RotatingSaw }
        
        [SerializeField] private HazardType hazardType = HazardType.StaticBarrier;
        [SerializeField] private float damageMultiplier = 1.0f;
        [SerializeField] private bool canBeDestroyedByShield = true;
    }
}
