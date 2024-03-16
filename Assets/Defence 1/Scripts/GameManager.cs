using Defence_1.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int StartHealth;
    public Hud Hud;
    public Border Border;

    private int _currentHealth;

    private void Start()
    {
        Border.OnEnemyCollide += OnEnemyCollide;
        Hud.RestartButton.onClick.AddListener(RestartGame);

        _currentHealth = StartHealth;
        Time.timeScale = 1;

        Hud.SetStartView(_currentHealth, StartHealth);
    }

    private void OnDisable()
    {
        Border.OnEnemyCollide -= OnEnemyCollide;
        Hud.RestartButton.onClick.RemoveListener(RestartGame);    
    }

    private void OnEnemyCollide()
    {
        _currentHealth--;
        Hud.UpdateHealthBar(_currentHealth, StartHealth);

        if (_currentHealth == 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        Hud.SetGameOverView();
        Time.timeScale = 0;
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
