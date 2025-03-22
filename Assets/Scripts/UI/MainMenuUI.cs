using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField]
    private Button playButton;

    [SerializeField]
    private Button quitButton;

    void Awake()
    {
        playButton.onClick.AddListener(() => 
        {
            Loader.Load(Loader.Scene.GameScene);
        });

        quitButton.onClick.AddListener(() => 
        {
            Debug.Log("Quit App");
            Application.Quit();
        });

        Time.timeScale = 1f;
    }
}
