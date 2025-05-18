using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;

    private Vector3 tempPos;

    [SerializeField]
    private float mimX, maxX;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (player == null)
        {
            return;
        }
        // Follow the player
        tempPos = transform.position;
        tempPos.x = player.position.x;

        if (tempPos.x < mimX)
        {
            tempPos.x = mimX;
        }
        else if (tempPos.x > maxX)
        {
            tempPos.x = maxX;
        }

        transform.position = tempPos;
    }
}
