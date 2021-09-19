using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Regist : MonoBehaviour
{
    public exportCsvScript ecs;
    public InputField inputfield;
    public GameObject Rank_Image;

    string path = "savedata.csv";
    string[] header = { "name", "num_enemy" };
    List<string[]> csvresult;

    public void ButtonClickRegist()
    {
        string[] data = { inputfield.text, DataScripts.Enemy_killed.ToString() };

        // ファイルが存在するかを確認
        if (ecs.CheckExixtCSV(path))
        {
            // ファイル追記（追加）
            ecs.AppendCSV(data, path);
        }
        else
        {
            // ファイル書き出し(上書き）
            ecs.OverWriteCSV(header, data, path);
        }

        Rank_Image.SetActive(true);
    }
}
