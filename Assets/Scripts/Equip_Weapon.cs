using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Equip_Weapon : MonoBehaviour
{
    [SerializeField]
    private GameObject Gun;
    public Transform WeaponParent;

    void Start()
    {
        Gun.GetComponent<Rigidbody>().isKinematic = true;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Drop();
        }
    }

    void Drop()
    {
        WeaponParent.DetachChildren();
        Gun.transform.eulerAngles = new Vector3(Gun.transform.position.x, Gun.transform.position.y, Gun.transform.position.z);
        Gun.GetComponent<Rigidbody>().isKinematic = false;
        Gun.GetComponent<MeshCollider>().enabled = true;
    }

    void Equip()
    {
        Gun.GetComponent<Rigidbody>().isKinematic = true;

        Gun.transform.position = WeaponParent.transform.position;
        Gun.transform.rotation = WeaponParent.transform.rotation;

        Gun.GetComponent<MeshCollider>().enabled = false;

        Gun.transform.SetParent(WeaponParent);


    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                Equip();
            }
        }
    }
}





