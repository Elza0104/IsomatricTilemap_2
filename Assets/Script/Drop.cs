using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public GameObject meteor;
    public GameObject ob;
    public void OnTriggerStay2D(Collider2D other)
    {
        meteor.SetActive(true);
        Destroy(gameObject, 1f);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<AudioSource>().Play();
    }
}
