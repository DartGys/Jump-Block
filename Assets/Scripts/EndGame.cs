using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    bool checkEnd = false;
    public GameObject Stickman;
    private Animator animator;
    public Collider[] StickmanColliders;
    public Rigidbody[] StickmanRigid;
    public Collider StickmanBoxColl;
    public GameOverScreen gameOverScreen;
    public WarpEffect warpEffect;

    void Start()
    {
        animator = Stickman.GetComponent<Animator>();
    }

    void Update()
    {
        if (staticBoleans.gameEndCheck)
        {
            if (!checkEnd)
            {
                checkEnd = true;
                GameEnd();
            }
        }
    }

    public void GameEnd()
    {
        warpEffect.EndWarpEffect();
        Stickman.transform.SetParent(null);
        Destroy(Stickman.GetComponent<Rigidbody>());
        animator.enabled = false;
        StickmanBoxColl.enabled = false;
        Debug.Log("GAME OVER!");
        for (int i = 0; i < 11; i++)
        {
            StickmanColliders[i].enabled = true;
            StickmanRigid[i].useGravity = true;
        }
        gameOverScreen.EndScreen();
    }
}
