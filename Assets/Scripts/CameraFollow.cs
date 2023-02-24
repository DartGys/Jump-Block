using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float forwardSpeed = 10f;
    Vector3 moveToZ = new Vector3(0, 0, 0);
    public SwipeAnim swipeAnim;
    public WarpEffect warpEffect;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            staticBoleans.gameStartCheck = true;
            swipeAnim.SwipeToPlay();
            warpEffect.StartWarpEffect();
        }
        if (staticBoleans.gameStartCheck && !staticBoleans.gameEndCheck)
        {
            moveToZ.z = +1f;
            transform.position += moveToZ * forwardSpeed * Time.deltaTime;
        }
    }

}
