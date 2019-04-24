using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class Launcher : MonoBehaviour
{

    public string ExecutePath;
    public string YoutubeUrl;

    public void Player_Game()
    {
        Process.Start(ExecutePath);
    }

    public void Quit_Launcher()
    {
        Application.Quit();
    }

    public void Open_Youtube()
    {
        Application.OpenURL(YoutubeUrl);        
    }
}
