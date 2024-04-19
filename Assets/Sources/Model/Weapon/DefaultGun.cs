using System;
using UnityEngine;

namespace Asteroids.Model
{
    public class DefaultGun
    {
        protected readonly Transformable _point;
        private readonly float _speed;

        protected float _lifetime;
        private Bullet _bullet;

        public DefaultGun(Transformable point, InfoGun infoGun)
        {
            _point = point;
            _speed = infoGun.SpeedDefaultBullet;
            _lifetime = infoGun.LifetimeDefaultBullet;
        }

        public virtual bool CanShot => true;

        public event Action<Bullet> Shot;

        public void Shoot()
        {
            if (CanShot == false)
                throw new InvalidOperationException();

            _bullet = GetBullet();
            Shot?.Invoke(_bullet);
        }

        protected virtual Bullet GetBullet() => new DefaultBullet(_point.Position, _lifetime, _speed, _point.Forward);
    }
}