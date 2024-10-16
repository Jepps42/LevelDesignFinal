using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopChest : MonoBehaviour
{

    //Variables 

    public GameObject Chest;

    public AudioSource ChestOpenFX;

    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Chest.GetComponent<Animator>().Play("OpenChest");
            ChestOpenFX.Play();
        }
    }
}
