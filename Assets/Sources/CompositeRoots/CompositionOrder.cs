using UnityEngine;

public class CompositionOrder : MonoBehaviour
{
    [SerializeField] private RootShip _rootShip;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private EndGameWindow _endGameWindow;

    private void Awake()
    {
        _rootShip.OnAwake();
    }

    private void OnEnable()
    {
        _rootShip.Enable();
        _endGameWindow.Enable();
    }

    private void OnDisable()
    {
        _rootShip.Disable();
        _endGameWindow.Disable();
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