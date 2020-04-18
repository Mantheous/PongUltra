using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void Start()
    {
        RectTransform pos = GetComponent<RectTransform>();
        pos.position = new Vector3(Screen.width / 2, pos.position.y, 0);
    }

    public void Reload()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
