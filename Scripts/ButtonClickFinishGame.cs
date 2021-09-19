using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClickFinishGame : MonoBehaviour
{
    public void BottonClikFinish()
    {
        SceneManager.LoadScene("Title");
    }
}
