using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject cube;
    public Vector3 jumpforce;
    // Use this for initialization
    void Start()
    {
        jumpforce = new Vector3(0f, 50f, 0f);

    }
    void OnTriggerEnter()
    {
        print("Collision Detected");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            cube.GetComponent<Rigidbody>().AddForce(jumpforce);
        }
    }

}