//UnZip.cs
using System;
using System.IO.Compression;
using System.Threading.Tasks;
using UnityEngine;

public class UnZip : MonoBehaviour
{
    private Progress<ZipProgress> _progress;
    private void Start()
    {
        _progress = new Progress<ZipProgress>();
        _progress.ProgressChanged += Report;
    }
    public async void Extract()
    {
        await Task.Run(() => UnZipTask("zipPath", "unzipPath"));
    }
    public void UnZipTask(string zipPath, string extratPath)
    {
        //ZipArchive zip = ZipFile.OpenRead(zipPath);
        //zip.ExtractToDirectory(extratPath, _progress);
    }
    private void Report(object sender, ZipProgress zipProgress)
    {
        //ここの値を何かしらの方法でProgressBarに入れる
        Debug.Log("Extract : " + zipProgress.CurrentItem + " " + zipProgress.Processed + " / " + zipProgress.Total);
    }
}
