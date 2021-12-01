using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBossDoorRight : MonoBehaviour
{

    [SerializeField] private Animator BossDoorOpenRight;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            BossDoorOpenRight.SetBool("OpenDoor", true);
        }
       
    }



}
