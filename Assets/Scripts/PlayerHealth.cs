using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    public Slider healthBar;

    void Start()
    {
        currentHealth = maxHealth;

        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
    }

    public void TakeDamage(int damage)
{
    currentHealth -= damage;

    healthBar.value = currentHealth;
    healthBar.maxValue = maxHealth;

    Debug.Log("Health: " + currentHealth);

    if (currentHealth <= 0)
    {
        Die();
    }
}

    void Die()
    {
        Debug.Log("GAME OVER");
        FindObjectOfType<GameManager>().GameOver();
        Destroy(gameObject);
    }
}