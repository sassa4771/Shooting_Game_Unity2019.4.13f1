using UnityEngine;
using System.Text;
using System.IO;
using System.Collections.Generic;

public class exportCsvScript : MonoBehaviour
{
    private List<string[]> csvDatas = new List<string[]>(); // CSVの中身を入れるリスト

    // ファイル書き出し(上書き）
    public void OverWriteCSV(string[] header, string[] data, string path)
    {
        // 現在のフォルダにsaveData.csvを出力する(決まった場所に出力したい場合は絶対パスを指定してください)
        // 引数説明：第1引数→ファイル出力先, 第2引数→ファイルに追記(true)or上書き(false), 第3引数→エンコード
        // falseにすると、ファイルを新規作成する
        StreamWriter sw = new StreamWriter(path, false, Encoding.GetEncoding("UTF-8"));

        string h = string.Join(",", header);
        sw.WriteLine(h);

        //ここで","を付けた形にする(str2に配列strに","を付けたものを代入する）
        string d = string.Join(",", data);

        //ここで初めて書き込む
        sw.WriteLine(d);

        // StreamWriterを閉じる
        sw.Close();


        Debug.Log(path);
    }


    // ファイル書き出し（追加）
    public void AppendCSV(string[] data, string path)
    {
        // 現在のフォルダにsaveData.csvを出力する(決まった場所に出力したい場合は絶対パスを指定してください)
        // 引数説明：第1引数→ファイル出力先, 第2引数→ファイルに追記(true)or上書き(false), 第3引数→エンコード
        // falseにすると、ファイルを新規作成する
        StreamWriter sw = new StreamWriter(path, true, Encoding.GetEncoding("UTF-8"));

        //ここで","を付けた形にする(str2に配列strに","を付けたものを代入する）
        string d = string.Join(",", data);

        //ここで初めて書き込む
        sw.WriteLine(d);

        // StreamWriterを閉じる
        sw.Close();

        Debug.Log(path);
    }

    //csvファイルの読み出し
    public List<string[]> ReadCSV(string path)
    {
        // ファイル読み込み
        // 引数説明：第1引数→ファイル読込先, 第2引数→エンコード
        //Unityのプロジェクトフォルダー内にある場合
        StreamReader sr = new StreamReader(path, Encoding.GetEncoding("UTF-8"));
        string line;

        // 行がnullじゃない間(つまり次の行がある場合は)、処理をする。→最後の行まで読みだす。
        while ((line = sr.ReadLine()) != null)
        {
            // コンソールに出力
            Debug.Log(line);
            csvDatas.Add(line.Split(','));
        }

        // StreamReaderを閉じる
        sr.Close();

        Debug.Log(path);

        return csvDatas;
    }

    //ファイルが存在するかを確認
    public bool CheckExixtCSV(string path)
    {
        if (System.IO.File.Exists(path))
        {
            Debug.Log("CSVファイルが存在するので追記します");
            return true;
        }
        else
        {
            Debug.Log("CSVファイルが存在しないので作成します");
            return false;
        }
    }
}