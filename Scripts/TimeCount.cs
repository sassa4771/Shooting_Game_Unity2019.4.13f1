using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    public Text FinishText;
    public GameObject ShowFinishText;
    

    //タイマーカウント用
    private float TimeOut = 60f;
    private float CurrentTime = 0;

    // Update is called once per frame
    void Update()
    {
        CurrentTime += Time.deltaTime;

        if(CurrentTime > TimeOut)
        {
            TimeUp();
        }

        ChangeText(CurrentTime);
    }

    void ChangeText(float Time)
    {
        if (!DataScripts.Finish_Game)
        {
            FinishText.text = (TimeOut - Time).ToString("f1") + "秒";
        }
    }

    void TimeUp()
    {
        DataScripts.Finish_Game = true;
        ShowFinishText.SetActive(true);
    }
}
