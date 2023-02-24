using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeStackEffect : MonoBehaviour
{
    public void stackEffect(Vector3 position)
    {

        Instantiate(gameObject, position, Quaternion.identity);
        Destroy(gameObject);

    }
}
