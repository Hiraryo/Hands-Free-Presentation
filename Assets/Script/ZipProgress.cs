using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZipProgress : MonoBehaviour
{
    public ZipProgress(int total, int processed, string currentItem)
    {
        Total = total;
        Processed = processed;
        CurrentItem = currentItem;
    }
    public int Total { get; }
    public int Processed { get; }
    public string CurrentItem { get; }
}
