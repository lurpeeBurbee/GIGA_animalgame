using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToDisappear : MonoBehaviour
{
    [SerializeField] GameObject dialogueBox;
    void Start()
    {
        
    }
public void OnDisable()
    {
        Debug.Log("Disappear");
        dialogueBox.SetActive(false);   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
