using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cams : MonoBehaviour
{

    public Vector3 camroate;
    public GameObject camera;
    void Start()
    {
        camera = GameObject.Find("Main Camera");
    }
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        float speed = 2f;
        transform.position += new Vector3(x / 1, 0, z / 1) * Time.deltaTime * speed;
    }
}