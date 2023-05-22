using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public GameObject healthBarUi;
    public Slider slider;
    private EnemySpawn es;

    private void Start()
    {
        es = transform.parent.GetComponent<EnemySpawn>();

        health = maxHealth;
        slider.value = CalculateHealth();
    }

    private void Update()
    {
        slider.value = CalculateHealth();

        if (health < maxHealth)
        {
            healthBarUi.SetActive(true);
        }

        if (health <= 0)
        {
            StartCoroutine(es.Respawn());
            Destroy(gameObject);
        }

        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    float CalculateHealth()
    {
        return health / maxHealth;
    }


}
