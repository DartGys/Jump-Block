using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    void OnTriggerEnter()
    {
        GameObject.Destroy(gameObject, 0);
    }
}
