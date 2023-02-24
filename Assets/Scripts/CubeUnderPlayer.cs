using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeUnderPlayer : MonoBehaviour
{
    bool check = false;

    void Start()
    {
        if (PlayerCube.Cube == null)
        {
            Debug.Log("Its fake null");
            PlayerCube.Cube = GameObject.FindWithTag("FirstCube");
            PlayerCube.SpawnPosition = PlayerCube.Cube.transform;
            Debug.Log(PlayerCube.Cube.transform);
            staticBoleans.gameEndCheck = false;
            staticBoleans.gameStartCheck = false;
        }
    }

    void Update()
    {
        CheckCubeUnderPlayer();
    }

    void CheckCubeUnderPlayer()
    {
        if (PlayerCube.Cube.transform.parent == null)
        {
            if (!check)
            {
                check = true;
                Debug.Log("Cube under player disappear!");
                staticBoleans.gameEndCheck = true;
            }
        }
    }
}
