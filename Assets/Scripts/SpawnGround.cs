using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{
    public GameObject[] Grounds;
    public GameObject PickUpCube;
    Vector3 SpawnPosition = new Vector3(0, 0, 0);
    Vector3 CubesSpawnPosition = new Vector3(0, 2.95f, -8);
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            spawnGround();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (staticBoleans.spawnGround && !staticBoleans.gameEndCheck)
        {
            spawnGround();
            staticBoleans.spawnGround = false;
        }
    }

    void spawnGround()
    {
        int index = Random.Range(0, 5);
        var nextPosGround = Instantiate(Grounds[index], SpawnPosition, Quaternion.identity);
        nextPosGround.transform.SetParent(GameObject.FindWithTag("Ground").transform);

        for (int i = 0; i < 3; i++)
        {
            var nextPosCube = Instantiate(PickUpCube, CubesSpawnPosition + new Vector3(Random.Range(-1.5f, 1.5f), 0, 0), Quaternion.identity);
            nextPosCube.transform.SetParent(GameObject.FindWithTag("PickUp").transform);
            CubesSpawnPosition += new Vector3(0, 0, 7.5f);
        }
        SpawnPosition = nextPosGround.transform.position + new Vector3(0, 0, 30);
        CubesSpawnPosition += new Vector3(0, 0, 7.5f);
    }
}
