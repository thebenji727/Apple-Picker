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
    public float changeDirChance = 5f;

    // seconds between apple creations
    public float appleDropDelay = 1f;
    void Start()
    {
        // Start dropping apples
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleDropDelay);
    }

    // Update is called once per frame
    void Update()
    {
        //basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        //changing direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // moves to the right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        else if (Random.value < changeDirChance) 
        {
            speed *= -1;
        }

        void FixedUpdate()
        {
            float chance = Random.value;
            if (chance < changeDirChance) 
            {
                Debug.Log("chance = " + chance);
                Debug.Log("changeDirChance = " + changeDirChance);
                speed *= -1;
            }

        }


}
}
