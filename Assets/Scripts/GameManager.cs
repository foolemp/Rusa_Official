using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager
{

    public static int levelScene = 0;
    public static int GameOverScene = 1;

    public static void ChangeScene(int i)
    {
        SceneManager.LoadScene(i);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
