using UnityEngine;

public class RootShip : MonoBehaviour
{
    [SerializeField] private ShipPresenter _shipPresenter;
    [SerializeField] private InfoShip _infoShip;
    [SerializeField] private InfoGun _infoGun;
    [SerializeField] private Camera _camera;
    [SerializeField] private Factory _factory;

    private Ship _ship;
    private ShipInputRouter _shipInputRouter;
    private DefaultGun _baseGun;
    private LaserGun _laserGun;

    public void OnAwake()
    {
        _ship = new Ship(_infoShip);
        _baseGun = new DefaultGun(_ship, _infoGun);
        _laserGun = new LaserGun(_ship, _infoGun);
        _shipInputRouter = new ShipInputRouter(_ship, _baseGun, _laserGun);
        _shipPresenter.Initialized(_ship, _camera, _factory);
    }

    public void Enable()
    {
        _shipInputRouter.OnEnable();
        _baseGun.Shot += OnShot;
        _laserGun.Shot += OnShot;
        _shipPresenter.ShipDisabled += DisableShip;
    }

    public void Disable()
    {
        _shipInputRouter.OnDisable();
        _baseGun.Shot -= OnShot;
        _laserGun.Shot -= OnShot;
        _shipPresenter.ShipDisabled -= DisableShip;
    }

    public void OnUpdate()
    {
        _shipInputRouter.Update(Time.deltaTime);
        _ship.Update(Time.deltaTime);
        _laserGun.Update(Time.deltaTime);
    }

    public void DisableShip()
    {
        _shipInputRouter.OnDisable();
    }

    private void OnShot(Bullet bullet) => _factory.CreateBullet(bullet);
}