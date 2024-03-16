using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    public Button RestartButton;
    public Image SliderValue;
    public GameObject GameOverPanel;
    public TextMeshProUGUI HealthText;

    public void SetStartView(float currentHealth, float startHealth)
    {
        UpdateHealthBar(currentHealth, startHealth);
        GameOverPanel.SetActive(false);
    }
    public void SetGameOverView()
    {
        GameOverPanel.SetActive(true);
    }

    public void UpdateHealthBar(float currentHealth, float startHealth)
    {
        HealthText.text = $"{currentHealth}/{startHealth}";
        SliderValue.fillAmount = currentHealth / startHealth;
    }
}
