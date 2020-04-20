using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class infoMeny : MonoBehaviour {
    public GameObject meny;
    public GameObject meny3;
    public bool trs;
   


    // Use this for initialization
    void Start () {meny3.gameObject.GetComponent<infoMeny>().enabled = false;
        
        
    }
	
	// Update is called once per frame
	void Update () {
		meny.gameObject.SetActive(trs); 
	}
}
