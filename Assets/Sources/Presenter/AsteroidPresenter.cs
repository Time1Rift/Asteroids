using UnityEngine;

public class AsteroidPresenter : EnemyPresenter
{
    private Factory _factory;

    public new Asteroid Transformable => base.Transformable as Asteroid;

    public void Initialized(Factory factory) => _factory = factory;

    protected override void IdentifyCollision()
    {
        _factory.CreateAsteroidParts(this);
        OnDestroying();
    }
}