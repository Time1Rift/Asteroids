using UnityEngine;

public abstract class Bullet : Transformable, IUpdatable
{
    private readonly float _lifetime;

    private float _accumulatedTime;

    public Bullet(Vector2 position, float lifetime) : base(position, 0)
    {
        _lifetime = lifetime;
    }

    public virtual void Update(float deltaTime)
    {
        _accumulatedTime += Time.deltaTime;

        if (_accumulatedTime >= _lifetime)
            Destroy();
    }
}