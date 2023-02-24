using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach : MonoBehaviour
{
    FixedJoint fixedJoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            fixedJoint.connectedBody = GameObject.FindWithTag("CubeUnder").GetComponent<Rigidbody>();
        }
        if (Input.GetKeyDown("x"))
        {
            fixedJoint.connectedBody = null;    
        }
    }
}
