using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public Button RestartButton;

    void Start()
    {
        RestartButton.onClick.AddListener(RestartButtonClicked);
    }

    private void RestartButtonClicked()
    {
        ChangeScenes(0);
    }

    private void ChangeScenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
    }
}