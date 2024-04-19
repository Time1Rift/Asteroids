using UnityEngine;

namespace Asteroids.Model
{
    public class Nlo : Enemy
    {
        private readonly float _speed;
        private readonly Transformable _target;

        private Vector2 _nextPosition;

        public Nlo(Vector2 position, float speed, Transformable target) : base(position, 0)
        {
            _speed = speed;
            _target = target;
        }

        public override void Update(float deltaTime)
        {
            _nextPosition = Vector2.MoveTowards(Position, _target.Position, _speed * deltaTime);
            Move(_nextPosition);
            LookAt(_target.Position);
        }

        private void LookAt(Vector2 point) => Rotate(Vector2.SignedAngle(Forward, (Position - point)));
    }
}