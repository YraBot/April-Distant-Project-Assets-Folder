using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelMover : MonoBehaviour
{
    public string sceneName;
    public void Move()
    {
        SceneManager.LoadScene(sceneName);
    }
}
