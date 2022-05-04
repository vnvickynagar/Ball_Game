using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Manager : MonoBehaviour
{
    public GameObject Start_Canvas;
    public GameObject Menu_Canvas;
    public GameObject Setting_Canvas;
    public GameObject Credits_Canvas;

    public void Start()
    {
        Start_Canvas.SetActive(true);
        Setting_Canvas.SetActive(false);
        Menu_Canvas.SetActive(false);
        Credits_Canvas.SetActive(false);
    }
    public void ManuEnable()
    {
        Start_Canvas.SetActive(false);
        Setting_Canvas.SetActive(false);
        Menu_Canvas.SetActive(true);
        Credits_Canvas.SetActive(false);
    }

    public void SettingButton()
    {
        Start_Canvas.SetActive(false);
        Setting_Canvas.SetActive(true);
        Menu_Canvas.SetActive(false);
        Credits_Canvas.SetActive(false);
    }

    public void CreditsButton()
    {
        Start_Canvas.SetActive(false);
        Setting_Canvas.SetActive(false);
        Menu_Canvas.SetActive(false);
        Credits_Canvas.SetActive(true);
    }

    public void BackButton()
    {
        Start_Canvas.SetActive(false);
        Setting_Canvas.SetActive(false);
        Menu_Canvas.SetActive(true);
        Credits_Canvas.SetActive(false);
    }
    public void Ext()
    {
        Application.Quit();
    }
}
