using UnityEngine;
using Asteroids.Model;

public class Presenter : MonoBehaviour
{
    [field: SerializeField] public TypePresenter Type {  get; private set; }

    private Transformable _transformable;
    private IUpdatable _updatable = null;
    private Transform _transform;
    private Camera _camera;
    private Factory _factory;

    public Transformable Transformable => _transformable;

    private void OnEnable()
    {
        _transformable.Moved += OnMoved;
        _transformable.Rotated += OnRotated;
        _transformable.Destroying += OnDestroying;
    }

    private void OnDisable()
    {
        _transformable.Moved -= OnMoved;
        _transformable.Rotated -= OnRotated;
        _transformable.Destroying -= OnDestroying;
    }

    private void Update()
    {
        _updatable?.Update(Time.deltaTime);
    }

    public void Initialized(Transformable transformable, Camera camera, Factory factory)
    {
        _camera = camera;
        _transform = transform;
        _transformable = transformable;
        _factory = factory;

        if (transformable is IUpdatable)
            _updatable = (IUpdatable)transformable;

        enabled = true;

        OnMoved();
        OnRotated();
    }

    protected void OnDestroying() => Destroy();

    protected void Destroy()
    {
        enabled = false;
        _transformable = null;
        _factory.SetObgect(this);
    }

    private Vector3 GetViewportPosition(Transformable transformable) => new Vector3(transformable.Position.x, transformable.Position.y, 1);

    private void OnMoved() => _transform.position = _camera.ViewportToWorldPoint(GetViewportPosition(_transformable));

    private void OnRotated() => _transform.rotation = Quaternion.Euler(0, 0, _transformable.Rotation);
}