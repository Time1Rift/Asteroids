using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameWindow : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private GameObject _window;
    [SerializeField] private ShipPresenter _shipPresenter;

    public void Enable()
    {
        _shipPresenter.ShipDisabled += Show;
    }

    public void Disable()
    {
        _shipPresenter.ShipDisabled -= Show;
    }

    private void Show()
    {
        _restartButton.onClick.RemoveAllListeners();
        _restartButton.onClick.AddListener(() => SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex));
        _window.SetActive(true);
    }
}