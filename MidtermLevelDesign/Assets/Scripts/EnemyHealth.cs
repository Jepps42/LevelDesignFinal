using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    [Header("Health Settings")]
    public float maxHealth = 100f; // Maximum health
    private float currentHealth;

    [Header("UI Components")]
    public Slider healthBarSlider; // The UI slider for health
    public Vector3 offset = new Vector3(0, 2, 0); // Offset above the enemy

    private Camera mainCamera; // Reference to the main camera

    void Start()
    {
        currentHealth = maxHealth; // Initialize health
        healthBarSlider.maxValue = maxHealth; // Set slider max value
        healthBarSlider.value = currentHealth; // Set initial slider value
        mainCamera = Camera.main; // Cache the main camera
    }

    void Update()
    {
        // Update the position of the health bar to follow the enemy
        if (healthBarSlider != null)
        {
            Vector3 worldPosition = transform.position + offset;
            Vector3 screenPosition = mainCamera.WorldToScreenPoint(worldPosition);
            healthBarSlider.transform.position = screenPosition;
        }
    }

    /*public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        healthBarSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Add death behavior here (e.g., destroy enemy, play animation)
        Destroy(gameObject);
    }*/
}
