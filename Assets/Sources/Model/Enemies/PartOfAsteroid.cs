using UnityEngine;

namespace Asteroids.Model
{
    public class PartOfAsteroid : Asteroid
    {
        public PartOfAsteroid(Vector2 position, Vector2 direction, float speed) : base(position, direction, speed) { }
    }
}