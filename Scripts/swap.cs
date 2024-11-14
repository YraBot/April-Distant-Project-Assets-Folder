using UnityEngine;

public class swap : MonoBehaviour
{
    public GameObject[] objectsToToggle;
    private int currentIndex = 0;

    
    public void ToggleActiveState()
    {

        foreach (var obj in objectsToToggle)
        {
            obj.SetActive(false);
        }


        currentIndex = (currentIndex + 1) % objectsToToggle.Length;

        
        objectsToToggle[currentIndex].SetActive(true);
    }
}
