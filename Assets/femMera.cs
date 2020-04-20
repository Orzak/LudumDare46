using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class femMera : MonoBehaviour {
    
    public GameObject vin;
    // Use this for initialization
    void Start () {
        this.GetComponent<spelController>().rundamax += 5;
        vin.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;

        this.GetComponent<femMera>().enabled = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
