using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
  public void MovetoScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void OnApplicationQuit()
    {

        int show = 5;
        Application.Quit();
        Debug.Log(show);
    }
}
