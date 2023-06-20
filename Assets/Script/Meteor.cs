using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Meteor : MonoBehaviour
{
    void Awake()
    {
        GetComponent<AudioSource>().Play();
    }
}
