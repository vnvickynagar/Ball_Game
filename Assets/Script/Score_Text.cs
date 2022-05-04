using UnityEngine;
using TMPro;

public class Score_Text : MonoBehaviour
{
    public TMP_Text Stxt;
    void Update()
    {
        Stxt.text = Score_Count.Score.ToString();
    }
}
