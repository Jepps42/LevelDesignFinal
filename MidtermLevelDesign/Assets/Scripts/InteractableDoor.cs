using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableDoor : MonoBehaviour
{
    //Variables
    public GameObject Door;

    public AudioSource DoorCreak;

    public GameObject DoorKnob;

    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Door.GetComponent<Animator>().Play("OpenDoor");
            DoorKnob.GetComponent<Animator>().Play("Handle");
            //DoorCreak.Play();
        }
    }
}
