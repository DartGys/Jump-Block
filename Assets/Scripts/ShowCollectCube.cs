using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowCollectCube : MonoBehaviour
{
    public void showCollect(Vector3 position)
    {
        Instantiate(gameObject, position, Quaternion.identity);
        gameObject.transform.position += new Vector3(0, 1, 0) * Time.deltaTime;
        Destroy(gameObject, 1);
    }
}
