using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public bool showHealthBar;
    public GameObject healthBarUi;
    public Slider slider;
    private EnemySpawn es;
    Points ps;
    public GameObject pointsGUI;

    private void Start()
    {
        ps = pointsGUI.GetComponent<Points>();
        health = maxHealth;
        slider.value = CalculateHealth();
    }

    private void Update()
    {
        slider.value = CalculateHealth();

        if (health < maxHealth && showHealthBar == true)
        {
            healthBarUi.SetActive(true);
        }

        if (health <= 0)
        {
            GameObject.Find(gameObject.name + ("spawn point")).GetComponent<EnemySpawn>().Death = true;
            //Then destroy it
            gameObject.SetActive(false);
            ps.UpdatePoints();
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
