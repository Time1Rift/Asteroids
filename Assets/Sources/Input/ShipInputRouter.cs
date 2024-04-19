using UnityEngine;
using UnityEngine.InputSystem;
using Asteroids.Model;

public class ShipInputRouter
{
    private ShipInput _input;
    private Ship _ship;

    private DefaultGun _defaultGun;
    private DefaultGun _laserGun;

    public ShipInputRouter(Ship ship, DefaultGun defaultGun, DefaultGun laserGun)
    {
        _input = new ShipInput();
        _ship = ship;
        _defaultGun = defaultGun;
        _laserGun = laserGun;
    }

    private float Direction => _input.Ship.Rotate.ReadValue<float>();

    public void OnEnable()
    {
        _input.Enable();
        _input.Ship.DefaultGun.performed += OnDefaultGun;
        _input.Ship.LaserGun.performed += OnLaserGun;
    }

    public void OnDisable()
    {
        _input.Disable();
        _input.Ship.DefaultGun.performed -= OnDefaultGun;
        _input.Ship.LaserGun.performed -= OnLaserGun;
    }

    public void Update(float deltaTime)
    {
        if (MoveForwardPerformed())
            _ship.Accelerate(deltaTime);
        else
            _ship.Slowdown(deltaTime);

        TryRotate(deltaTime);
    }

    private bool MoveForwardPerformed() => _input.Ship.MoveForward.phase == InputActionPhase.Performed;

    private void TryRotate(float deltaTime)
    {
        if (Direction != 0)
            _ship.Rotate(Direction, deltaTime);
    }

    private void OnDefaultGun(InputAction.CallbackContext context) => TryShoot(_defaultGun);

    private void OnLaserGun(InputAction.CallbackContext context) => TryShoot(_laserGun);

    private void TryShoot(DefaultGun defaultGun)
    {
        if (defaultGun.CanShot)
            defaultGun.Shoot();
    }
}