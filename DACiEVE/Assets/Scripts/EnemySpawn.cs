using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public bool Death;
    public float Timer;
    public float Cooldown;
    public GameObject Enemy;
    string EnemyName;
    GameObject LastEnemy;
    
    // Use this for initialization
    void Start()
    {
        
        Death = false;
        EnemyName = Enemy.name;
        this.gameObject.name = EnemyName + "spawn point";
        Enemy.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Death == true)
        {
            //If my enemy is death, a timer will start.
            
            Timer += Time.deltaTime;

        }
        //If the timer is bigger than cooldown.
        if (Timer >= Cooldown)
        {
            Enemy.SetActive(true);
            Enemy.GetComponent<EnemyHealth>().health = Enemy.GetComponent<EnemyHealth>().maxHealth;
            Death = false;
            //Timer will restart.
            Timer = 0;
        }
    }
}
