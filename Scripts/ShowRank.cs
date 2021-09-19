using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShowRank : MonoBehaviour
{
    public exportCsvScript ecs;
    string path = "savedata.csv";
    List<string[]> csvresult;
    List<csv_sorted> cs = new List<csv_sorted>();

    //Text
    public Text Rank1;
    public Text Rank2;
    public Text Rank3;
    public Text Rank4;
    public Text Rank5;
    public Text Rank6;
    int i=1;

    private bool finish_bool = false;
    float timecount = 0;

    // Start is called before the first frame update
    void OnEnable()
    {    
        csvresult = ecs.ReadCSV(path);
        make_csv_sort(csvresult);
        cs.Sort((a, b) => b.num_enemy - a.num_enemy);

        //順位６番までを表示
        foreach (var ds in cs)
        {
            switch (i)
            {
                case 1:
                    Rank1.text = ds.name  + " " + ds.num_enemy.ToString() + "体";
                    break;

                case 2:
                    Rank2.text = ds.name + " " + ds.num_enemy.ToString() + "体";
                    break;

                case 3:
                    Rank3.text = ds.name + " " + ds.num_enemy.ToString() + "体";
                    break;

                case 4:
                    Rank4.text = ds.name + " " + ds.num_enemy.ToString() + "体";
                    break;

                case 5:
                    Rank5.text = ds.name + " " + ds.num_enemy.ToString() + "体";
                    break;

                case 6:
                    Rank6.text = ds.name + " " + ds.num_enemy.ToString() + "体";
                    break;

                default:
                    break;
            }

            i++;
        }

        finish_bool = true;
    }

    void make_csv_sort(List<string[]> csv)
    {
        int i = 0;
        foreach (string[] c in csv)
        {
            if (i != 0)
            {
                cs.Add(new csv_sorted { name = c[0], num_enemy = int.Parse(c[1]) });
            }
            i++;
        }
    }

    private void Update()
    {
        if (finish_bool)
        {
            timecount += Time.deltaTime;

            if (timecount > 10) SceneManager.LoadScene("Title");
        }
    }
}

public class csv_sorted
{
    public string name { get; set; }
    public int num_enemy { get; set; }
}