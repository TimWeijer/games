using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorComponent : MonoBehaviour
{
    public GameObject MeteorPrefab;
    public GameObject Player;
    private GameObject newmeteor;
    private Vector3 center;

    private void Start()
    {
        newmeteor = Instantiate(MeteorPrefab, new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f)), Quaternion.identity);
        center = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z);
        MoveMeteor();
    }

private void Update()
    {
        
    }

    private void MoveMeteor()
    {
/*        newmeteor.transform.position = Vector3.Lerp(newmeteor.transform.position, center, 20f);
*/        print(newmeteor.transform.position);
    }
}
