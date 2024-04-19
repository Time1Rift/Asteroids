using UnityEngine;

namespace Asteroids.Model
{
    public class Asteroid : Enemy
    {
        private readonly float _speed;
        private readonly Vector2 _direction;

        public Asteroid(Vector2 position, Vector2 direction, float speed) : base(position, 0)
        {
            _direction = direction;
            _speed = speed;
        }

        public override void Update(float deltaTime) => Move(Position + _direction * _speed * deltaTime);

        public PartOfAsteroid CreatePart() => new PartOfAsteroid(Position, Random.insideUnitCircle.normalized, _speed / 2);
    }
}