using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardBall : MonoBehaviour
{ //по аналогии с ball
    private float velocity = 10.0f;

    private Rigidbody HardSphere;

    void Start()
    {
        HardSphere = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    { transform.position += new Vector3(1 * Time.deltaTime * velocity, 0, 0);
        
    }

}
