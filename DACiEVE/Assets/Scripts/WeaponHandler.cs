using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour
{
    [Header("Weapon")]
    public KeyCode shootButton = KeyCode.Mouse0;
    public KeyCode equipWeapon = KeyCode.E;
    public GameObject weaponHolder;
    public GameObject gun1;
    private bool hasGun;
    private GameObject newGun;

    private void Update()
    {
        CheckForInput();
    }

    private void FixedUpdate()
    {
        if (hasGun)
        {
            moveGun();
        }
    }

    private void CheckForInput()
    {
        if (Input.GetKeyDown(equipWeapon))
        {
            EquipWeapon();
        }
    }

    private void EquipWeapon()
    {
        newGun = Instantiate(gun1, weaponHolder.transform.position, weaponHolder.transform.rotation);

        hasGun = true;
    }

    private void moveGun()
    {
        newGun.transform.position = weaponHolder.transform.position;
        newGun.transform.rotation = weaponHolder.transform.rotation;
    }
}
