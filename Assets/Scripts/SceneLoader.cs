using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private Button _startButton;

    private void Start()
    {
        _startButton.onClick.AddListener(StartButtonClicked);
    }

    private void StartButtonClicked()
    {
        ChangeScenes(1);
    }

    private void ChangeScenes(int numberOfTheScene)
    {
        SceneManager.LoadScene(numberOfTheScene);
    }
}