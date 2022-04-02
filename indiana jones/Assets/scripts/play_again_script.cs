using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class play_again_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            restartGame();
        }
    }

    public void restartGame()
    {
       EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().name);
        print("restart");
    }
}
