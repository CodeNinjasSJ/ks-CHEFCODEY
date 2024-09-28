using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getthestuff : MonoBehaviour
{
    public string triggerName = "";
    public GameObject breadPrefab;
    public GameObject heldItem;
    public string heldItemName;
    public stove stove;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (triggerName == "Bread")
            {
                heldItem = Instantiate(breadPrefab, transform, false);
                heldItem.transform.localPosition = new Vector3(0, 2, 2);
                heldItemName = "breadSlice";
            }
           
            if (triggerName == "Stove")
            {
                if (heldItemName == "bread")
                {
                    stove.ToastBread();
                    PlaceHeldItem();
                   
                }
                else
                {
                    if (stove.cookedFood == "toast")
                    {
                        heldItem = Instantiate(breadPrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 2, 2);
                        heldItemName = "toastSlice";
                        stove.CleanStove();
                    }
                }
                if (triggerName == "Recievers")
                {
                    
                    if (heldItemName == "toastSlice")
                    {
                        PlaceHeldItem();
                    }
                }
            }
          



        }
    }
    private void PlaceHeldItem()
    {
        Destroy(heldItem);
        heldItemName = "";
    }
    private void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }
}



