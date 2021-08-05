using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddItem : MonoBehaviour
{
    private Inventary inventary;
    public GameObject itemButton;
    bool Pressed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("ok");
        Pressed = true;
    }

    private void OnMouseUp()
    {
        Pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Pressed)
        {
            Vector3 mousePos = Input.mousePosition;
            for (int i = 0; i < inventary.slots.Length; i++)
            {
                if(inventary.isFull[i] == false)
                {
                    inventary.isFull[i] = true;
                    break;
                }
            }
            Handheld.Vibrate();
            Destroy(gameObject);
        }
    }

}
