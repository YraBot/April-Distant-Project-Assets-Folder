using UnityEngine;

public class swap1 : MonoBehaviour
{
    public GameObject[] objectsToToggle;
    private int currentIndex = 0;


    public void ToggleActiveState()
    {

        foreach (var obj in objectsToToggle)
        {
            obj.SetActive(false);
        }

        currentIndex = (currentIndex - 1) % objectsToToggle.Length;

        if (currentIndex < 0) currentIndex = objectsToToggle.Length - 1;
        objectsToToggle[currentIndex].SetActive(true);
    }
}
