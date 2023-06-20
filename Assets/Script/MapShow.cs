using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MapShow : MonoBehaviour
{
    [SerializeField] private GameObject map;
    public void OnTriggerStay2D(Collider2D other)
    {
        map.SetActive(true);
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        map.SetActive(false);
    }
}
