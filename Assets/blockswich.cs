using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockswich : MonoBehaviour {

    bool playerNear;
    public LayerMask playerLager;
    // Use this for initialization
    void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {

    
        if ((1 << other.gameObject.layer & playerLager.value) != 0)
        {
            playerNear = true;
        }
    }
    private void OnTriggerExit(Collider other)
{


        if ((1 << other.gameObject.layer & playerLager.value) != 0)
        {
            playerNear = false;
        }
    }

   

    private void Update()
        {

            if (playerNear && Input.GetButtonUp("Fire2"))
            {

            if (transform.GetChild(0).gameObject.activeInHierarchy ==false) {
                transform.GetChild(0).gameObject.SetActive(true);
            } else { transform.GetChild(0).gameObject.SetActive(false); }

                

                
               
                
                 

        }

    }
        
}
