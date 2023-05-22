using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy, transform);
    }

    public IEnumerator Respawn()
    {

        Debug.Log("Started wait");

        yield return new WaitForSeconds(5);

        Debug.Log("Finished, respawning");

        Instantiate(enemy, transform);
    }
}
