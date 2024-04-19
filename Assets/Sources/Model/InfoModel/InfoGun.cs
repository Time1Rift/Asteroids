using UnityEngine;

[CreateAssetMenu(fileName = "New InfoGun", menuName = "Info/Create new InfoGun", order = 51)]
public class InfoGun : ScriptableObject
{
    [field: SerializeField, Min(0f)] public float SpeedDefaultBullet { get; private set; } = 0.6f;
    [field: SerializeField, Min(0f)] public float LifetimeDefaultBullet { get; private set; } = 10f;

    [field: SerializeField, Min(0)] public int MaxLaserBullets { get; private set; } = 3;
    [field: SerializeField, Min(0)] public int BulletsPerShot { get; private set; } = 1;
    [field: SerializeField, Min(0f)] public float LifetimeLaserGunBullet { get; private set; } = 0.5f;
    [field: SerializeField, Min(0f)] public float Cooldown { get; private set; } = 2f;
}