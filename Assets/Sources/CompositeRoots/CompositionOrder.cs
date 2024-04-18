using UnityEngine;

public class CompositionOrder : MonoBehaviour
{
    [SerializeField] private RootShip _rootShip;
    [SerializeField] private EndGameWindow _endGameWindow;

    private void Awake()
    {
        _rootShip.Initialized();
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
}