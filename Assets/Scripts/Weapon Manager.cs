using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    // Maximum ammo and reserve ammo for primary and secondary weapons
    public int MaxAmmoPrimary;
    public int MaxAmmoReservePrimary;
    public int MaxAmmoSecondary;
    public int MaxAmmoReserveSecondary;

    // Current equipped primary and secondary weapon
    public WeaponType currentPrimaryWeapon;
    public WeaponType currentSecondaryWeapon;

    // Enum defining different weapon types
    public enum WeaponType
    {
        // Primary weapons
        Revolver,   // Pistol-like weapon
        Rifle,      // Assault rifle
        Shotgun,    // Shotgun
        Sniper,     // Sniper rifle

        // Secondary weapons
        Pistol,     // Secondary pistol
        SMG,        // Submachine gun
        Launcher,   // Rocket launcher
        Crossbow    // Crossbow
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialize with default weapons
        SetPrimaryWeapon(WeaponType.Revolver); // Start with revolver as default primary weapon
        SetSecondaryWeapon(WeaponType.Pistol); // Start with pistol as default secondary weapon
    }

    // Update is called once per frame
    void Update()
    {
        // For simplicity, let's assume there might be some ammunition reloading logic or other functionality here
    }

    // Method to set the primary weapon
    public void SetPrimaryWeapon(WeaponType weapon)
    {
        currentPrimaryWeapon = weapon;

        // Set ammo values based on the selected primary weapon
        switch (currentPrimaryWeapon)
        {
            case WeaponType.Revolver:
                MaxAmmoPrimary = 6;
                MaxAmmoReservePrimary = 60;
                break;
            case WeaponType.Rifle:
                MaxAmmoPrimary = 30;
                MaxAmmoReservePrimary = 120;
                break;
            case WeaponType.Shotgun:
                MaxAmmoPrimary = 8;
                MaxAmmoReservePrimary = 40;
                break;
            case WeaponType.Sniper:
                MaxAmmoPrimary = 5;
                MaxAmmoReservePrimary = 25;
                break;
            default:
                Debug.LogWarning("Unknown primary weapon type");
                break;
        }
    }

    // Method to set the secondary weapon
    public void SetSecondaryWeapon(WeaponType weapon)
    {
        currentSecondaryWeapon = weapon;

        // Set ammo values based on the selected secondary weapon
        switch (currentSecondaryWeapon)
        {
            case WeaponType.Pistol:
                MaxAmmoSecondary = 10;
                MaxAmmoReserveSecondary = 50;
                break;
            case WeaponType.SMG:
                MaxAmmoSecondary = 30;
                MaxAmmoReserveSecondary = 120;
                break;
            case WeaponType.Launcher:
                MaxAmmoSecondary = 1;
                MaxAmmoReserveSecondary = 5;
                break;
            case WeaponType.Crossbow:
                MaxAmmoSecondary = 1;
                MaxAmmoReserveSecondary = 10;
                break;
            default:
                Debug.LogWarning("Unknown secondary weapon type");
                break;
        }
    }
}
