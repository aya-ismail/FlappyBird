using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Vector3 range;
    // Start is called before the first frame update
    void Awake()
    {

        range = transform.position - birdTransform.position;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(range.x + birdTransform.position.x, transform.position.y, range.z + birdTransform.position.z);
    }

}
