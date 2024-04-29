using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Equip_Weapon : MonoBehaviour
{
    bool Weapon_Collided_with;
    [SerializeField]
    private GameObject Gun_Position; // where the weapon will rest after being equiped
    [SerializeField]
    private GameObject Gun; // the weapon to equip // this might be changed later  to add more weapons
    public float Equip_Speed = 5.0f;

    void Start()
    {

    }


    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E) && Weapon_Collided_with == true)
        {
            Gun.transform.position = Vector3.MoveTowards(Gun.transform.position, Gun_Position.transform.position, Equip_Speed * Time.deltaTime);
            Gun.transform.parent = Gun_Position.transform;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Weapon"))
        {
            Debug.Log("weapon collided with");
            Weapon_Collided_with = true;

        }
    }
}
/*  if player is within  the collider  than the weapon is able to be equipped, Tap e to bring the weapon closer.
 *   If you left click the mouse the gun shoots.
 */