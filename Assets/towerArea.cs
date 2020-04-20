using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class towerArea : MonoBehaviour
{

    public LayerMask frendLager;
    public LayerMask playerLager;

    public float mode=1f;
    followTower mids;

    Collider tower;
    LinkedList<healt> heal;

    public Renderer roofRenderer;
    public Text target;

    bool playerNear;


    // Use this for initialization
    void Start()
    {
        heal = new LinkedList<healt>();
        tower = GetComponent<Collider>();
        mids = transform.GetChild(0).GetComponent<followTower>();
    

}
    private void Update()
    {
        if (playerNear && Input.GetButtonUp("Fire2"))
        {

            if (mids.mode == followTower.Mode.First)
            {
                roofRenderer.material.color = Color.white;
                target.text = "Closest";
                mids.mode = followTower.Mode.Closest; mode = 1;
            }
            else if (mids.mode == followTower.Mode.Closest)
            {
                mids.mode = followTower.Mode.Lowest; mode = 2;
                roofRenderer.material.color = Color.red;
                target.text = "Lowest";
            }
            else if (mids.mode == followTower.Mode.Lowest)
            {
                mids.mode = followTower.Mode.First; mode = 3;
                roofRenderer.material.color = Color.blue;
                target.text = "First";
            }
            print(mids.mode);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if ((1 << other.gameObject.layer & frendLager.value) != 0)
        {
            heal.AddLast(other.gameObject.GetComponent<healt>());
            
        }
        if ((1 << other.gameObject.layer & playerLager.value) != 0)
        {
            playerNear = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if ((1 << other.gameObject.layer & frendLager.value) != 0)
        {
            heal.Remove(other.gameObject.GetComponent<healt>());
        }
        if ((1 << other.gameObject.layer & playerLager.value) != 0)
        {
            playerNear = false;
        }
    }

    public healt GetTarget()
    {
        if (heal.Count == 0)
            return null;
        if (heal.First.Value)
            return heal.First.Value;
        else
        {
            heal.RemoveFirst();
            return GetTarget();
            
        }
    }

    public healt GetClosestTarget()
    {
        if (heal.Count == 0)
            return null;
        if (!heal.First.Value) {
            heal.RemoveFirst();
            return GetClosestTarget();
        } else {
            var node = heal.First;
            float dist2 = Vector3.SqrMagnitude(transform.position - node.Value.transform.position);
            var selected = node.Value;
            while (node != null)
            {
                if (node.Value)
                {
                    float ndist2 = Vector3.SqrMagnitude(transform.position - node.Value.transform.position);
                    if (ndist2 < dist2)
                    {
                        dist2 = ndist2;
                        selected = node.Value;
                    }
                }
                else
                {
                    heal.Remove(node);
                }
                node = node.Next;
            }
            return selected;
        }
    }
    public healt GetLowestHealtTarget()
    {
        if (heal.Count == 0)
            return null;
        if (!heal.First.Value)
        {
            heal.RemoveFirst();
            return GetLowestHealtTarget();
        }
        else
        {
            var node = heal.First;
            float Lhealt = node.Value.healtt;
            var selected = node.Value;
            while(node != null)
            {
                if (node.Value)
                {
                    float nLhealt = node.Value.healtt;
                    if (nLhealt < Lhealt)
                    {
                        Lhealt = nLhealt;
                        selected = node.Value;
                    }
                }
                else
                {
                    heal.Remove(node);
                }
                node = node.Next;
            }
            return selected;
        }
    }
}