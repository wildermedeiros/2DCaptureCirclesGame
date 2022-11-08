using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleKeeper : MonoBehaviour
{
    [SerializeField] CircleSpawner circleSpawner = null;
    [SerializeField] bool hasWinned = false;
    [SerializeField] bool hasLoosed = false;
    [SerializeField] int nextSceneToLoad;
 
    void Update()
    {
        if (hasWinned) { return; }
        if (transform.childCount <= 0)
        {
            circleSpawner.CancelInvoke();
            hasWinned = true;
            SceneManager.LoadScene(nextSceneToLoad);
        }

        if (hasLoosed) { return; }
        if(transform.childCount >= 20)
        {
            circleSpawner.CancelInvoke();
            hasLoosed = true;
            SceneManager.LoadScene(0);
        }
    }

    public int GetCircleCount()
    {
        return transform.childCount;
    }
}
