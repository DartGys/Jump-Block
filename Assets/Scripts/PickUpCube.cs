using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCube : MonoBehaviour
{
    private GameObject Player;
    public GameObject Prefab;
    public ShowCollectCube showCollectCube;
    public CubeStackEffect cubeStackEffect;
    void Start()
    {
        Player = GameObject.FindWithTag("Stickman");
        Debug.Log(Player.name);
    }
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "PickUpCube")
        {
            showCollectCube.showCollect(PlayerCube.SpawnPosition.position);
            cubeStackEffect.stackEffect(PlayerCube.SpawnPosition.position);
            staticBoleans.animatorCheck = true;
            Player.transform.position += new Vector3(0, 1f, 0);
            Debug.Log("Hit!");
            PlayerCube.Cube = Instantiate(Prefab, PlayerCube.SpawnPosition.position + new Vector3(0, 1.1f, 0),
            PlayerCube.SpawnPosition.rotation);
            PlayerCube.Cube.transform.SetParent(GameObject.FindWithTag("CubeHolder").transform);
            PlayerCube.SpawnPosition = PlayerCube.Cube.transform;
            Destroy(GameObject.FindWithTag("StackEffect"), 1);
            Destroy(GameObject.FindWithTag("CollectCube"), 1);
        }
    }
}
