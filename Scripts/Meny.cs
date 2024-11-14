using UnityEngine;
using UnityEngine.SceneManagement;

public class Meny : MonoBehaviour
{
    public GameObject[] objects;          
    public string sceneName;              
    public void OpenScene()
    {
        
        foreach (GameObject obj in objects)
        {
           
            if (obj.activeInHierarchy)
            {
               
                data.skpr = obj;

            }
        }

       
        SceneManager.LoadScene(sceneName);
    }
}
