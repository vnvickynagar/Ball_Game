using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour
{
    public void ChangeLevel(string SceneName)
    {
        Debug.Log("Change Scene");
        SceneManager.LoadScene(SceneName);
    }
}
