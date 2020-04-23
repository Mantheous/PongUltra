using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public int sceneNumber;
    public bool UseSpace;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && UseSpace)
        {
            Load();
        }
    }

    public void Load()
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
