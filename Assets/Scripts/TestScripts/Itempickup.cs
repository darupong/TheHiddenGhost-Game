using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Itempickup : MonoBehaviour
{
    private Inventary inventory;
    public GameObject itemButton;
    bool Pressed = false;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1");
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventary>();
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
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("ok1");
            if (Pressed)
            {
                Debug.Log("ok2");
                Vector3 mousePos = Input.mousePosition;
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    if (inventory.isFull[i] == false)
                    {
                        inventory.isFull[i] = true;
                        Instantiate(itemButton, inventory.slots[i].transform, false);
                        Destroy(gameObject);
                        break;
                    }
                }
            }
        }
    }
}
