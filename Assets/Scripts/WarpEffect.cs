using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpEffect : MonoBehaviour
{
    public void StartWarpEffect()
    {
        gameObject.SetActive(true);
    }

    public void EndWarpEffect()
    {
        gameObject.SetActive(false);
    }
}
