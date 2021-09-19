using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClickGameStart : MonoBehaviour
{
    public void BottonClikStart(){
        SceneManager.LoadScene("MainGame");
    }
}
