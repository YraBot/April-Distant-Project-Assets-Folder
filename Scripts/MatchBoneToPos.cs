using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchBoneToPos : MonoBehaviour
{
    public bool work = false;
    public Transform tr;
    Quaternion basicRotation;
    Vector3 basicPosition;
    private void Awake()
    {
        basicRotation = transform.rotation;
        basicPosition = transform.position;
    }
    void Update()
    {
        if (work)
        {
            transform.position = tr.position+basicPosition;
            transform.rotation = Quaternion.Euler(tr.rotation.x+basicRotation.x, tr.rotation.y + basicRotation.y, tr.rotation.z + basicRotation.z);
        }
    }
    public void enableWork() { work = true; }
    public void disableWork() { work = false;}
}
