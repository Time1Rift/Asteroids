using UnityEngine;

public class LaserGunBullet : Bullet
{
    public LaserGunBullet(Vector2 position, float lifetime, Vector2 direction) : base(position, lifetime)
    {
        Rotate(Vector2.SignedAngle(Vector2.up, direction));
    }
}