using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class BallColliderTest : MonoBehaviour {
    
    void OnCollisionEnter(Collision collision)
    { 
        Destroy(this.gameObject);
    }
}