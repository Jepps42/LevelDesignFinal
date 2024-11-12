using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestLock : MonoBehaviour
{

    //Variables

    public GameObject Lock;

    public AudioSource DropLockfx;

    public GameObject Chest;

    public AudioSource ChestOpenFX;


    //Player colliding with lock, plays animation. Useful to call animations to play
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Lock.GetComponent<Animator>().Play("LockDrop");
            Chest.GetComponent<Animator>().Play("OpenChest");
            //ChestOpenFX.Play();
            //DropLockfx.Play();
        }
    }
    
}
