using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    public Transform teleport;
    private void OnCollisionEnter2D(Collision2D other)
    {
        print("qwudh");
        player.transform.position = teleport.position;
        GetComponent<AudioSource>().Play();
    }
}
