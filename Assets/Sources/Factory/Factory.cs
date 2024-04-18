using UnityEngine;

public class Factory : ObjectPool
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Presenter _laserGunBulletTemplate;
    [SerializeField] private Presenter _defaultGunBulletTemplate;
    [SerializeField] private Presenter _asteroidTemplate;
    [SerializeField] private Presenter _asteroidPartTemplate;
    [SerializeField] private Presenter _nloTemplate;

    private Presenter _presenter;

    public void CreateBullet(Bullet bullet)
    {
        if (bullet is LaserGunBullet)
            CreatePresenter(_laserGunBulletTemplate, bullet);
        else
            CreatePresenter(_defaultGunBulletTemplate, bullet);
    }

    public void CreateNlo(Nlo nlo) => CreatePresenter(_nloTemplate, nlo);

    public void CreateAsteroid(Asteroid asteroid)
    {
        AsteroidPresenter presenter = CreatePresenter(_asteroidTemplate, asteroid) as AsteroidPresenter;
        presenter.Initialized(this);
    }

    public void CreateAsteroidParts(AsteroidPresenter asteroid)
    {
        for (int i = 0; i < 4; i++)
            CreatePresenter(_asteroidPartTemplate, asteroid.Transformable.CreatePart());
    }

    private Presenter CreatePresenter(Presenter template, Transformable model)
    {
        _presenter = GetObject(template);
        _presenter.Initialized(model, _camera, this);
        return _presenter;
    }
}