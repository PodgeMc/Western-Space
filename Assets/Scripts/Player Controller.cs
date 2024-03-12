using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed = 5f;
    public float rotationSpeed = 2f;
    private Rigidbody rb;

    public int ammo;
    public float health;
    public float armour;
    public float maxAmmo;
    public string weaponType;
    public float maxHealth = 100;
    public float maxArmour = 100;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        armour = maxArmour;
    }

    void Update()
    {

    }
}
