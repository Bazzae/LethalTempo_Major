using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputWindow : MonoBehaviour
{
    //

   public bool isPlaying = true; 
    void Awake()
    {
        StartCoroutine(StartDelay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartDelay()
    {
        while (isPlaying == true)
        {
            yield return new WaitForSeconds (2f);
            Debug.Log("nikonikoni");
        }
        Input.GetButtonDown("P1Button1");
    }
}
