using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_Enemy_Killed_Num : MonoBehaviour
{
    //点数を表示するUI Textをここでアタッチ
    public Text num_enemy_killed;

    // Update is called once per frame
    void Update()
    {
        //毎フレームごとに点数を書き換える
        num_enemy_killed.text = "倒した数： " + DataScripts.Enemy_killed.ToString() + " 体";
    }
}
