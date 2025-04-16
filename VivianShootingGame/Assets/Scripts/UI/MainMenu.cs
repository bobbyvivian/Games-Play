using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject instructionsPanel;
    public string gameSceneName;

    private int nextCount;

    public TextMeshProUGUI instructionsText;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowInstructions()
    {
        SceneManager.LoadScene(2);
    }

    public void HideInstructions()
    {
        instructionsPanel.SetActive(false);
    }

    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }




}
