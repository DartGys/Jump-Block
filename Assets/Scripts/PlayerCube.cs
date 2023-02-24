using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerCube
{
    public static Transform SpawnPosition = GameObject.FindWithTag("FirstCube").transform;

    public static GameObject Cube = GameObject.FindWithTag("FirstCube");
}
