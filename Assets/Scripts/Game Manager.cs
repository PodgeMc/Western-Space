using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int Timer;

    public GameObject FirstPersonCamera;
    public GameObject ThirdPersonCamera;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Timer = Timer + 1;
    }
}
