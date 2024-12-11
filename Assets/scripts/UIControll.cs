using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class UIController : MonoBehaviour
{
    GameObject sampleButtonUI;
    private UIDocument _uiDocument;
    public TMPro.TextMeshProUGUI text;
    public GameObject target;
    void Start()
    {
        // PrefabÇ©ÇÁUIÇê∂ê¨
        var buttonObject = Instantiate(sampleButtonUI);

        // UIDocumentÇÃéQè∆Çï€ë∂
        _uiDocument = buttonObject.GetComponent<UIDocument>();
        _uiDocument.rootVisualElement.Q<Button>("TheClickButton").clicked += () =>
        {
            text.text = "You have been captured!";
        };
    }
    void Update()
    {
         float distance = Vector3.Distance(transform.position, target.transform.position);
         if (distance < 10f)
            {
             transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 4f * Time.deltaTime);
         }
         else
         {
             transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 0f * Time.deltaTime);
         }
    }
}
