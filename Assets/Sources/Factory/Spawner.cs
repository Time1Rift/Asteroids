using UnityEngine;
using Asteroids.Model;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Factory _factory;
    [SerializeField] private Presenter _shipPresenter;
    [SerializeField] private InfoSpawner _info;

    private float _timer = 0f;
    private int _chance;
    private Vector2 _position;
    private Vector2 _direction;

    public void Start()
    {
        _timer = _info.TimeSpawn;
    }

    public void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            _timer = _info.TimeSpawn;
            OnTick();
        }
    }

    private void OnTick()
    {
        _chance = Random.Range(0, _info.MaxPercentage);
        
        if (_chance < _info.ChanceNlo)
        {
            _factory.CreateNlo(new Nlo(GetRandomPosition(), _info.SpeedNlo, _shipPresenter.Transformable));
        }
        else
        {
            _position = GetRandomPosition();
            _direction = GetRandomDirection(_position);
            _factory.CreateAsteroid(new Asteroid(_position, _direction, _info.SpeedAsteroid));
        }
    }

    private Vector2 GetRandomPosition() => Random.insideUnitCircle.normalized + _info.RandomPositionFactor;

    private Vector2 GetRandomDirection(Vector2 postion) => (new Vector2(Random.value, Random.value) - postion).normalized;
}