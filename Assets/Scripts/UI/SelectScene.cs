using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour
{
    public void ghost1()
    {
        SceneManager.LoadScene(1);
    }

    public void ghost2()
    {
        SceneManager.LoadScene(2);
    }

    public void ghost3()
    {
        SceneManager.LoadScene(3);
    }

    public void ghost4()
    {
        SceneManager.LoadScene(4);
    }
}
