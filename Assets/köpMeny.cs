using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class köpMeny : MonoBehaviour {
    BoxCollider meny;
    public bool fred;
    public GameObject player;
    public GameObject bygg1;
    public GameObject bygg2;
    public GameObject bygg3;
    public GameObject bygg4;
    public GameObject bygg5;
    public GameObject marker;
    spelController byt;
    private bool playerNear;
    public LayerMask playerLager;
    void Start () {
        meny = GetComponent<BoxCollider>();
        byt = player.GetComponent<spelController>();


    }
    private void OnTriggerEnter(Collider other)
    {


        if ((1 << other.gameObject.layer & playerLager.value) != 0)
        {
            playerNear = true;
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {


        if ((1 << other.gameObject.layer & playerLager.value) != 0)
        {
            playerNear = false;
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }



    private void Update()
    {

        
        if (playerNear && Input.GetKeyDown(KeyCode.Alpha1)) {
            
            if (byt.slavvar > 0.5)
            {
                byt.slavvar -= 1;
                Instantiate(bygg1, transform.position, Quaternion.identity);
                Transform.Destroy(this.gameObject); 
            }
        }
        if (playerNear && Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (byt.slavvar > 0.5)
            {
                byt.slavvar -= 1;
                Instantiate(bygg2, transform.position, Quaternion.identity);
                Transform.Destroy(this.gameObject);
            }
        }
        if (playerNear && Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (byt.slavvar > 0.5)
            {
                byt.slavvar -= 1;
                Instantiate(bygg3, transform.position, Quaternion.identity);
                Transform.Destroy(this.gameObject);
            }
        }
        if (playerNear && Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (byt.slavvar > -1)
            {
                Instantiate(bygg4, transform.position, Quaternion.identity);
                Transform.Destroy(this.gameObject); 
            }
        }
        if (playerNear && Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (byt.slavvar > 0.5)
            {
                byt.slavvar -= 1;
                Instantiate(bygg5, transform.position, Quaternion.identity);
                Transform.Destroy(this.gameObject);
            }
        }
    }
 
}
