using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClickShowRegister : MonoBehaviour
{
    public GameObject register;
    public void ButtonClickShow()
    {
        register.SetActive(true);
    }
}
