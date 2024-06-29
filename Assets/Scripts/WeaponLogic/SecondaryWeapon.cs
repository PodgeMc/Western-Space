using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryWeapon : MonoBehaviour
{
    int Current_Ammo;
    int Max_Ammo;

    bool Is_Secondary_Weapon;



    void Start()
    {

    }


    void Update()
    {

    }

    void FireRate()
    {
        //to do

    }

    void Ammo()
    {
        //to do
        if (Is_Secondary_Weapon == true)
        {
            Current_Ammo = Max_Ammo;

        }
    }

    void WeaponDamage()
    {
        //to do
    }

    void WeaponAnimation()
    {
        //to do
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Shotgun" || other.gameObject.tag == "Rifle")
        {
            Debug.Log("this is a secondary weapon !");
            Is_Secondary_Weapon = true;
        }
    }
}
