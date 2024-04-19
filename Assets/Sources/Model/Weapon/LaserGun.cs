using System;
using UnityEngine;

namespace Asteroids.Model
{
    public class LaserGun : DefaultGun, IUpdatable
    {
        private int _bulletsPerShot;
        private int _maxBullets;
        private int _bullets;
        private float _accumulatedTime;
        private float _cooldown;

        public LaserGun(Transformable point, InfoGun infoGun) : base(point, infoGun)
        {
            if (infoGun.MaxLaserBullets <= 0)
                throw new ArgumentOutOfRangeException(nameof(infoGun.MaxLaserBullets));

            if (infoGun.BulletsPerShot < 0)
                throw new ArgumentOutOfRangeException(nameof(infoGun.BulletsPerShot));

            _bulletsPerShot = infoGun.BulletsPerShot;
            _bullets = infoGun.MaxLaserBullets;
            _lifetime = infoGun.LifetimeLaserGunBullet;
            _cooldown = infoGun.Cooldown;
            _maxBullets = _bullets;
        }

        public override bool CanShot => _bullets >= _bulletsPerShot;

        public event Action ShotAdd;

        public void Update(float deltaTime)
        {
            _accumulatedTime += Time.deltaTime;

            if (_accumulatedTime >= _cooldown)
            {
                TryAddShot();
                _accumulatedTime = 0f;
            }
        }

        private void TryAddShot()
        {
            if (_bullets + _bulletsPerShot > _maxBullets)
                return;

            _bullets += _bulletsPerShot;
            ShotAdd?.Invoke();
        }

        protected override Bullet GetBullet()
        {
            _bullets -= _bulletsPerShot;
            return new LaserGunBullet(_point.Position, _lifetime, _point.Forward);
        }
    }
}