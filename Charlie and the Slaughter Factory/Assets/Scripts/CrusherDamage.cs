﻿using UnityEngine;
using System.Collections;


public class CrusherDamage : MonoBehaviour {
    private int attackDamage = 100;  //Damage taken due to hit

    PlayerHealth playerHealth;  // Reference to the Charlie's health.
    PlayerScript playerScript; //Reference to Charlie's movement controls
    GameObject player;  // Reference to Charlie
    Rigidbody2D rigidBody;

    void Awake() {
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        rigidBody = player.GetComponent<Rigidbody2D>();
    }

    void Update() {
    }

	void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject == player){
            playerHealth.TakeDamage(attackDamage);
        }
    }
}