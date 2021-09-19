using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize_Value : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataScripts.Finish_Game = false;
        DataScripts.Enemy_killed = 0;
    }
}
