using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PrimaryWeapon : MonoBehaviour
{
    public SimpleShoot SS; // reference to SimpleShoot Script




    int Primary_Current_Ammo;
    int Primary_Max_Ammo;



    bool Is_Primary_Weapon1; // check if machine gun was equiped

    bool Is_Primary_Weapon2; // check if handgun was equiped

    public GameObject Bullet_Prefab;


    [Header(" Refrences for Machinegun")]
    [SerializeField] Transform Barrel_Location_Machine_Gun;
    [Tooltip("Bullet Speed")][SerializeField] private float BulletSpeed = 500f;

    [Header(" Refrences for Handgun")]
    [SerializeField] Transform barrelLocation;
    [Tooltip("Bullet Speed")][SerializeField] private float shotPower = 500f;


    void Start()
    {

    }


    void Update()
    {
        Shoot();
    }


    void Shoot()
    {
        //click mouse and gun shoots // if ammo is zero nothing happens 



        //--------------MACHINEGUN-------------//

        if (!Bullet_Prefab)
        { return; }

        if (Equip_Weapon.Weapon_Count == 1)
        {
            if (Is_Primary_Weapon1 == true && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Machinegun is firing");
                // Create a bullet and add force on it in direction of the barrel
                Instantiate(Bullet_Prefab, Barrel_Location_Machine_Gun.position, Barrel_Location_Machine_Gun.rotation).GetComponent<Rigidbody>().AddForce(Barrel_Location_Machine_Gun.forward * BulletSpeed);
            }
        }

        //---------------HANDGUN---------------//

        if (Equip_Weapon.Weapon_Count == 1)
        {
            if (Is_Primary_Weapon2 == true && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Handgun is firing");
                SS.gunAnimator.SetTrigger("Fire");

                // Create a bullet and add force on it in direction of the barrel
                Instantiate(Bullet_Prefab, barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * BulletSpeed);
            }
        }



    }

    void FireRate()
    {
        //if mouse is clicked and it is a primary weapon and ammo is > than 0 
        // check if mouse was clicked, wait for few seconds then shoot again 
    }

    void Ammo()
    {
        if (Is_Primary_Weapon1 == true || Is_Primary_Weapon2 == true)
        {
            Primary_Current_Ammo = Primary_Max_Ammo;

        }

        // gain ammo by walking into it and if you dont ammo remains at zero 
    }

    void WeaponDamage()
    {
        //to do
    }

    void WeaponAnimation()
    {
        //if mouse buutton was clicked and ammo is greater > zero animation plays 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "MachineGun")
        {
            Is_Primary_Weapon1 = true;

        }
        if (other.gameObject.tag == "Handgun")
        {
            Is_Primary_Weapon2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "MachineGun")
        {
            Is_Primary_Weapon1 = false;

        }
        if (other.gameObject.tag == "Handgun")
        {
            Is_Primary_Weapon2 = false;
        }
    }
}
