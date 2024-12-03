using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{

    //Variables 
    public GameObject doorCollider;


    // Start is called before the first frame update
    void Start()
    {
        doorCollider.SetActive(true);
    }

   public void GoKey()
    {
        
       
            doorCollider.SetActive(false);
            Destroy(gameObject);
       
    }
}
