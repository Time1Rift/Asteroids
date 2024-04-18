using UnityEngine;

public class DefaultBullet : Bullet
{
    private readonly Vector2 _direction;
    private readonly float _speed;

    private Vector2 _nextPosition;

    public DefaultBullet(Vector2 position, float lifetime, float speed, Vector2 direction) : base(position, lifetime)
    {
        _speed = speed;
        _direction = direction;
    }

    public override void Update(float deltaTime)
    {
        _nextPosition = Position + _direction * _speed * deltaTime;
        Move(_nextPosition);
        base.Update(deltaTime);
    }
}