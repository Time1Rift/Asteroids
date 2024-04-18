using UnityEngine;

public class CompositionOrder : MonoBehaviour
{
    [SerializeField] private RootShip _rootShip;
    [SerializeField] private Spawner _spawner;

    private void Awake()
    {
        _rootShip.OnAwake();
    }

    private void OnEnable()
    {
        _rootShip.Enable();
    }

    private void OnDisable()
    {
        _rootShip.Disable();
    }

    private void Start()
    {
        _spawner.OnStart();
    }

    private void Update()
    {
        _rootShip.OnUpdate();
        _spawner.OnUpdate();
    }
}