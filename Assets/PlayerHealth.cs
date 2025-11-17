using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 6;
    public int currentHealth;
    public HealthUI healthUI;

    void Start()
    {
        currentHealth = maxHealth;
        if (healthUI != null)
            healthUI.SetHealth(currentHealth);
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth < 0)
            currentHealth = 0;

        if (healthUI != null)
            healthUI.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
         
            SceneManager.LoadScene("level-game-over");
        }
    }

    public void AddHealth(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;

        if (healthUI != null)
            healthUI.SetHealth(currentHealth);
    }
}
