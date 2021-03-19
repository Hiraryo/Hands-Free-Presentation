using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UnityEngine;

public class Micro : MonoBehaviour
{
    [SerializeField, Range(0f, 10f)] float m_gain = 1f; // 音量に掛ける倍率
    private float m_volumeRate; // 音量(0-1)
    public GameObject[] Slide;
    int page;
    // Use this for initialization
    void Start()
    {   //これで特定のアプリを起動できる
        //Process.Start("/Applications/Safari.app");

        // サブディレクトリ内のファイルもカウントする場合
        //int fileCount = Directory.GetFiles(dir, "*", SearchOption.AllDirectories).Length;

        //UnityEngine.Debug.Log("ファイル数 : "+fileCount);
        AudioSource aud = GetComponent<AudioSource>();
        if ((aud != null) && (Microphone.devices.Length > 0)) // オーディオソースとマイクがある
        {
            string devName = Microphone.devices[0]; // 複数見つかってもとりあえず0番目のマイクを使用
            int minFreq, maxFreq;
            Microphone.GetDeviceCaps(devName, out minFreq, out maxFreq); // 最大最小サンプリング数を得る
            aud.clip = Microphone.Start(devName, true, 2, minFreq); // 音の大きさを取るだけなので最小サンプリングで十分
            aud.Play(); //マイクをオーディオソースとして実行(Play)開始
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (m_volumeRate > 0.02f)
        {
            page++;
            Slide[page - 1].SetActive(false);
            Slide[page].SetActive(true);
        }
        UnityEngine.Debug.Log(m_volumeRate);
    }

    // オーディオが読まれるたびに実行される
    private void OnAudioFilterRead(float[] data, int channels)
    {
        float sum = 0f;
        for (int i = 0; i < data.Length; ++i)
        {
            sum += Mathf.Abs(data[i]); // データ（波形）の絶対値を足す
        }
        // データ数で割ったものに倍率をかけて音量とする
        m_volumeRate = Mathf.Clamp01(sum * m_gain / (float)data.Length);
    }
}
