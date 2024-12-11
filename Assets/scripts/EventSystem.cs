using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EventSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public Text title;
    void OnCollisionEnter(Collision collision)
    {
        title.text = "(( ´∀｀ ))";
    }
}
