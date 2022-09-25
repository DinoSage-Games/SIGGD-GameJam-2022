using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private Image healthBar;
    public float currentHealth;
    private float maxHealth = 100f;
    HealthStat healthStat;

    private void Start()
    {
        healthBar = GetComponent<Image>();
        healthStat = FindObjectOfType<HealthStat>();
    }

    private void Update()
    {
        currentHealth = healthStat.getHealth();

        healthBar.fillAmount = currentHealth / maxHealth;
    }

}
