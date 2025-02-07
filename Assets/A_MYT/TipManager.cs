using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TipManager : MonoBehaviour
{
    public static TipManager instance;

    private void Awake()
    {
        instance = this;

        Invoke(nameof(AddTip1), 5);
        Invoke(nameof(AddTip2), 10);
    }

    public void AddTip1()
    {
        AddTip("±£¥Ê");
    }

    public void AddTip2()
    {
        AddTip("÷ß¿Î∆∆ÀÈ");
    }

    public void AddTip(string text)
    {
        transform.position = Camera.main.transform.position + Camera.main.transform.forward * 3;
        GetComponentInChildren<TextMeshProUGUI>().text = text;
    }
}
