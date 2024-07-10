using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SecondaryWeapon : MonoBehaviour
{



    int Secondary_Current_Ammo;
    int Secondary_Max_Ammo;



    bool Is_Secondary_Weapon1; // check if Shotgun was equiped

    bool Is_Secondary_Weapon2; // check if Rifle was equiped

    public GameObject Bullet_Prefab;


    [Header(" Refrences for Shotgun")]
    [SerializeField] Transform barrel_Location_Shotgun;
    [Tooltip("Bullet Speed")][SerializeField] private float BulletSpeed = 500f;

    [Header(" Refrences for Rifle")]
    [SerializeField] Transform barrelLocation_Rifle;
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

        //-------- Shotgun-------------//

        if (Equip_Weapon.Weapon_Count == 1)
        {
            if (Is_Secondary_Weapon1 == true && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Shotgun is firing");


                // Create a bullet and add force on it in direction of the barrel
                Instantiate(Bullet_Prefab, barrel_Location_Shotgun.position, barrel_Location_Shotgun.rotation).GetComponent<Rigidbody>().AddForce(barrel_Location_Shotgun.forward * BulletSpeed);
            }
        }





        //--------RIFLE--------------//

        if (Equip_Weapon.Weapon_Count == 1)
        {
            if (Is_Secondary_Weapon2 == true && Input.GetMouseButtonDown(0))
            {
                Debug.Log("Rifle is firing");


                // Create a bullet and add force on it in direction of the barrel
                Instantiate(Bullet_Prefab, barrelLocation_Rifle.position, barrelLocation_Rifle.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation_Rifle.forward * BulletSpeed);
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
        if (Is_Secondary_Weapon1 == true || Is_Secondary_Weapon2 == true)
        {
            Secondary_Current_Ammo = Secondary_Max_Ammo;

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
        if (other.gameObject.tag == "Shotgun")
        {
            Is_Secondary_Weapon1 = true;

        }
        if (other.gameObject.tag == "Rifle")
        {
            Is_Secondary_Weapon2 = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Shotgun")
        {
            Is_Secondary_Weapon1 = false;

        }
        if (other.gameObject.tag == "Rifle")
        {
            Is_Secondary_Weapon2 = false;
        }
    }
}
