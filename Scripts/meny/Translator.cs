using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Translator : MonoBehaviour
{
    private TextMesh txt;
    public string[] variants;
    private void Start()
    {
        txt = GetComponent<TextMesh>();
    }
    void FixedUpdate()
    {
        txt.text = variants[GeneralInfo.language];
    }
}
public static class GeneralInfo
{
    public static byte language = 1;//0 - ru, 1 - en
}