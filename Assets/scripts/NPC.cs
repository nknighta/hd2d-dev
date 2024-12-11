using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        float speed = 10f;
        transform.position += new Vector3(x / 1, 0, z / 1) * Time.deltaTime * speed;
    }
}
