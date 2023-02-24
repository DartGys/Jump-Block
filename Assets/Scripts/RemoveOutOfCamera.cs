using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveOutOfCamera : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
