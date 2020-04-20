using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject frend;
    public GameObject player;
    spelController byt;
    private float gammalAmount = 0f;
    public float pågåendeAmount = 0f;
    public float spawndelay = 60f;
    private float time;

    // Use this for initialization
    void Start()
    {
        byt = player.GetComponent<spelController>();
        time = spawndelay;
    }

    // Update is called once per frame
    void Update()
    {
        if (byt.frendAmount != gammalAmount)
        {
            pågåendeAmount += byt.frendAmount;
            gammalAmount = byt.frendAmount;
        }
        if (pågåendeAmount > 0f)
        {
            if (time < 0f)
            {
                pågåendeAmount -= 1;
                Instantiate(frend, transform.position, Quaternion.identity);
                time += spawndelay;
                
            }
            time -= Time.deltaTime;
        }

    }
}
