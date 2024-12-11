using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;
using TMPro;

public class ShipMove : MonoBehaviour
{
    // Update is called once per frame
    public TMPro.TextMeshProUGUI title;
    public TMPro.TextMeshProUGUI speedDisp;
    private Vector3 velocity;
    float speed = 1f;
    private Animator animator;
    private void Start()
    {   
        animator = GetComponent<Animator>();
    }
    private void Update()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        
        transform.position += new Vector3(x / 1, 0, z * 2) * Time.deltaTime * speed;

        title.text = "x: " + x + " z: " + z + "stattis"+ "";

        if (x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            animator.SetFloat("world_walker", 0.1f);
            title.text = "x: " + x + " z: " + z + "stattis: " + "world_walker";
        }
        else if (x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            animator.SetFloat("world_walker", 0.1f);
            title.text = "x: " + x + " z: " + z + "stattis: " + "world_walker";
        }
        else if (x == 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            animator.SetFloat("world_walker", 0f);
            title.text = "x: " + x + " z: " + z + "stattis: " + "idle";
        }

    }
}