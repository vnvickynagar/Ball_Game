using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject completeLUI;
    public GameObject FailLUI;
    public string Next_Level;
    public string Home;
    //bool gameEnded = false;
    public void endGame()
    {
        completeLUI.SetActive(enabled);
        Invoke("NextLevel", 5f);

    }
    public void NextLevel()
    {
            SceneManager.LoadScene(Next_Level);   
    }
    public void reStart()
    {
        Invoke("Homee", 4f);
        FailLUI.SetActive(enabled);
        
        
    }
    public void Homee()
    {
        Score_Count.Score = 0;
        SceneManager.LoadScene(Home);   
    }
}
