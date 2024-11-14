using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLanguage : MonoBehaviour
{
    public byte language = 0;
    public Transform flag;
    public void Set()
    {
        GeneralInfo.language = language;
        flag.position = transform.position;
    }
    private void Awake()
    {
        if(GeneralInfo.language == language) flag.position = transform.position;
    }
}
