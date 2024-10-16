using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestLock : MonoBehaviour
{

    //Variables

    public GameObject Lock;

    public AudioSource DropLockfx;
   

    //Player colliding with lock, plays animation. Useful to call animations to play
    private void OnTriggerEnter(Collider other)
    {
            if (Input.GetKey(KeyCode.Q))
            {
                Lock.GetComponent<Animator>().Play("Lock Drop");
                DropLockfx.Play();
            }
    }
}
