using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor;

public class GameEvent_Text : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TextMeshProUGUI text;
    private GameObject target;
    void OnCollisionEnter(Collision collision)
    {
        target = GameObject.Find("Player_blank");

        if (collision.gameObject.tag == "Player")
        {
            text.text = "Game Over";
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }   
    void Update()
    {
        target = GameObject.Find("Player_blank");

        float distance = Vector3.Distance(target.transform.position, target.transform.position);
        
        if (distance < 14f)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0.5f * Time.deltaTime);
        } else
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0f * Time.deltaTime);
        }
    }
}
