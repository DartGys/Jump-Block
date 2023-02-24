using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHitByPlayer : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Debug.Log("Hit by player");
            staticBoleans.gameEndCheck = true;
        }
    }
}
