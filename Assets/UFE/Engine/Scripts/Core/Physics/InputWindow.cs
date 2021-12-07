using System.Collections;
using System.Collections.Generic;
using FPLibrary;
using UnityEngine;

namespace UFE3D
{
    public class InputWindow : MonoBehaviour
    {

        public bool isPlaying {get;set;}
        void Start()
        {
            StartCoroutine(StartDelay());
        }

        IEnumerator StartDelay()
        {
            if (isPlaying)
            {
                yield return new WaitForSeconds (5f);
                UFE.config.lockInputs = true;

            }
            else
            {
                yield return new WaitForSeconds(5f);
                UFE.config.lockInputs = false;
            }
            StartCoroutine(StartDelay());
        }
    }
}

