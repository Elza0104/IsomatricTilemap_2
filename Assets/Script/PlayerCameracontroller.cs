using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameracontroller : MonoBehaviour
{
    private Transform playerPos;

    private float smoothSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, 
                                            new Vector3(playerPos.position.x, playerPos.position.y, transform.position.z), 
                                            smoothSpeed * Time.deltaTime);
    }
}
