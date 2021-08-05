using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelOpen : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Selected;
    

    public void OpenPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
            
        }
        
    }
    public void SelectGhost()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
            Selected.SetActive(isActive);
        }
    }

    public void Currect()
    {
        Score.score += 10;
        SceneManager.LoadScene(2);
    }
}
