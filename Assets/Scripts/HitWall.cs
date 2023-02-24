using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitWall : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Wall")
        {

            Debug.Log("Hit wall");
            gameObject.transform.SetParent(null);
        }

    }


}
