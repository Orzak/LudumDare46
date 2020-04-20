using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spelController : MonoBehaviour {

    public float startSlavar;
    public float slavvar;
    public float runda;
    public float rundamax;
    public float frendAmount;
    public float leveldiff;
    public float level;
    public float dödaMax;
    public float döda;
    public float levde;
    void Start () {
        slavvar = startSlavar;
	}


    void Update() {
        if (levde+1 > (frendAmount - dödaMax)) { 
            if (Input.GetKeyUp(KeyCode.Return)) {
                levde = 0;
                runda += 1;
                frendAmount = runda * leveldiff;
                slavvar += 1;
            }
        }
        if (runda < 0.5f && Input.GetKeyUp(KeyCode.Return))
        {
            levde = 0;
            runda += 1;
            frendAmount = runda * leveldiff;
            slavvar += 1;
        }


    }
}
