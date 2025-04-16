using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class Menu : MonoBehaviour
{
    public FirstPersonController player;
    public GameObject gameOverPanel;

    private void Start()
    {
        gameOverPanel.SetActive(false);
    }

    private void Update()
    {
        // Check if player's health is zero or below to show game over panel
        if (player.health <= 0)
        {
            ShowGameOverPanel();
        }
    }

    private void ShowGameOverPanel()
    {
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reload current scene
    }

    private void Quit2Game()
    {
        Application.Quit();
    }

    // Public method to start the game (can be used with UI button)
    public void StartGame()
    {
        SceneManager.LoadScene("Game3");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    // Public method to quit the game (can be used with UI button)
    public void QuitGame()
    {
        Application.Quit();
    }
}
