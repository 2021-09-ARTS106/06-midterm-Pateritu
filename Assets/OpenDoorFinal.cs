using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorRight : MonoBehaviour
{

    [SerializeField] private Animator OpenFinalDoor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OpenFinalDoor.SetBool("OpenDoor", true);
        }

    }



}
