using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject applePrefab;
    // speed at which appletree moves
    public float speed = 1f;

    //Distance where appletree turns
    public float leftAndRightEdge = 10f;

    // RNG to change direction
    public float changeDirChance = 0.1f;

    // seconds between apple creations
    public float appleDropDelay = 1f;
    void Start()
    {
        // Start dropping apples
    }

    // Update is called once per frame
    void Update()
    {
        //basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        //changing direction

    }
}
