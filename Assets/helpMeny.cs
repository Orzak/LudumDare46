using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpMeny : MonoBehaviour {
    public GameObject meny;

    // Use this for initialization
    void Start () {
        meny = transform.GetChild(0).gameObject;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Tab))
        {
           
            meny.gameObject.SetActive(true);

        }
        else {  meny.gameObject.SetActive(false); }
    }
}
