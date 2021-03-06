﻿using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

/// <summary>
/// Script created by: Andrew Viney
/// </summary>
public class Mine : MonoBehaviourPunCallbacks
{
    [SerializeField] private float speed;
    [SerializeField] private int damage;

    public GameObject owner;
    private Rigidbody rb;

    public float getSpeed()//old code from bullet template may be removed
    {
        return speed;
    }
  
    public void InitializeMine(GameObject owner)
    {
        rb = GetComponent<Rigidbody>();
        this.owner = owner;
      
    }
    
      
  

    public int getDamage()
    {
        return damage;
    }

    public void hit()//iff mine destroyed
    {
        owner.GetComponent<Player>().RpcCreateHitParticle(transform.position);
       
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)//if collision occures
    {
        if (collision.gameObject != owner)
        {
            if (collision.transform.tag == "Player")
            {
                collision.gameObject.GetComponent<Player>().hitDetected(damage, owner.GetComponent<Player>());//deal damage
                owner.GetComponent<Player>().RpcCreateHitParticle(transform.position);//effect
                Destroy(gameObject);//get rid of object
            }
            owner.GetComponent<Player>().RpcExplosiveParticle(transform.position);
          
            Destroy(gameObject);
        }
    }
}
