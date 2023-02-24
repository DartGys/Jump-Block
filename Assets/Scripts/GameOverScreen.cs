using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void EndScreen()
    {
        gameObject.SetActive(true);
    }

    public void RestartButton()
    {
        Debug.Log("Button was pressed");
        SceneManager.LoadScene("Scene1");
    }
}
