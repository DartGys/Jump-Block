using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnParent : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (staticBoleans.gameEndCheck)
        {
            for (int i = gameObject.transform.childCount - 1; i >= 0; i--)
            {
                gameObject.transform.GetChild(i).gameObject.transform.SetParent(null);
            }
        }
    }
}
