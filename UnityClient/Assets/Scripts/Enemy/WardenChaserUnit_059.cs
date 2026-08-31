namespace RelicRun.Enemy
{
    using UnityEngine;

    /// <summary>
    /// The Warden Chaser AI #059
    /// Calculates dynamic stalking distance, player mistake penalty pacing, and lunge attacks.
    /// </summary>
    public class WardenChaserUnit_059 : MonoBehaviour
    {
        [SerializeField] private float baseFollowDistance = 12.0f;
        [SerializeField] private float dangerDistance = 3.5f;
        [SerializeField] private float catchUpSpeed = 16.5f;
    }
}
