using System;
using UnityEngine;

namespace Asteroids.Model
{
    public class Ship : Transformable, IUpdatable
    {
        private readonly float _unitsPerSecond;
        private readonly float _maxSpeed;
        private readonly float _secondsToStop;
        private readonly float _degreesPerSecond;

        private Vector2 _nextPosition;

        public Ship(InfoShip info) : base(info.Position, info.Rotation)
        {
            _unitsPerSecond = info.UnitsPerSecond;
            _maxSpeed = info.MaxSpeed;
            _secondsToStop = info.SecondsToStop;
            _degreesPerSecond = info.DegreesPerSecond;
        }

        public Vector2 Acceleration { get; private set; }

        public void Accelerate(float deltaTime)
        {
            Acceleration += Forward * (_unitsPerSecond * deltaTime);
            Acceleration = Vector2.ClampMagnitude(Acceleration, _maxSpeed);
        }

        public void Slowdown(float deltaTime) => Acceleration -= Acceleration * (deltaTime / _secondsToStop);

        public void Rotate(float direction, float deltaTime)
        {
            if (direction == 0)
                throw new InvalidOperationException(nameof(direction));

            direction = direction > 0 ? 1 : -1;
            Rotate(direction * deltaTime * _degreesPerSecond);
        }

        public void Update(float deltaTime) => MoveTo(Acceleration);

        private void MoveTo(Vector2 delta)
        {
            _nextPosition = Position + delta;
            _nextPosition.x = Mathf.Repeat(_nextPosition.x, 1);
            _nextPosition.y = Mathf.Repeat(_nextPosition.y, 1);
            Move(_nextPosition);
        }
    }
}