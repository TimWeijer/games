using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class WeaponHandler : MonoBehaviour
{
    [Header("Weapon")]
    public KeyCode shootButton = KeyCode.Mouse0;
    public KeyCode equipWeapon = KeyCode.E;
    public GameObject weaponHolder;
    public GameObject gun1;
    private bool hasGun;
    private GameObject newGun;
    public Sprite Bullet;
    public ParticleSystem bulletHitParticle;
    public ParticleSystem bloodHitParticle;
    private GameObject shootPos;
    Ray ray;

    private void Update()
    {
        CheckForInput();
    }

    private void CheckForInput()
    {
        if (Input.GetKeyDown(equipWeapon) && !hasGun)
        {
            EquipWeapon();
        } 
        else if (Input.GetKeyDown(equipWeapon) && hasGun)
        {
            DestroyWeapon();
        }
        else if (Input.GetMouseButtonDown(0) && hasGun)
        {
            Shoot();
        }
    }

    private void EquipWeapon()
    {
        newGun = Instantiate(gun1, weaponHolder.transform.position, weaponHolder.transform.rotation);

        newGun.transform.SetParent(weaponHolder.transform);

        hasGun = true;
    }
    private void DestroyWeapon()
    {
        Destroy(weaponHolder.transform.GetChild(0).gameObject);

        hasGun = false;
    }

    private void Shoot()
    {
        ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.gameObject.transform.parent && hit.collider.gameObject.transform.parent.name == "EnemyHitBox")
            {
                EnemyHealth healthScript = hit.collider.GetComponentInParent<EnemyHealth>();
                if (hit.collider.gameObject.transform.name != "Head")
                {
                    healthScript.health -= 2;
                } else
                {
                    healthScript.health -= 10;
                }
                Instantiate(bloodHitParticle, hit.point, Quaternion.LookRotation(hit.normal));
            }
            else
            {
               Instantiate(bulletHitParticle, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }
}
