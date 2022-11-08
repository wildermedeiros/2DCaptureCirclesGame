using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public void LevelChanger(int sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
