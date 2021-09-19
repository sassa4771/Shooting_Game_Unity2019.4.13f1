
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataScripts : ScriptableObject
{
    public static int Enemy_killed = 0;    //ループの回数の同期をとるため（Player_exportCsvScriptに依存）
    public static bool Finish_Game = false;
}