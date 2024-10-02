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
    public GameObject eggPrefab;
    public GameObject friedEggPrefab;

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
                PickUpItem(breadPrefab, "breadSlice");
            }

            if (triggerName == "Stove")
            {
                if (heldItemName == "breadSlice")
                {
                    stove.ToastBread();
                    PlaceHeldItem();
                    stove.ToastBread();

                }
                else if (heldItemName == "egg")
                {
                    stove.FryEgg();
                    PlaceHeldItem();
                    stove.FryEgg();
                }
                else
                {
                    if (stove.cookedFood == "toast")
                    {
                        PickUpItem(breadPrefab, "toastSlice");
                        stove.CleanStove();
                    }
                    if (stove.cookedFood == "friedEgg")
                    {
                        PickUpItem(friedEggPrefab, "friedEgg");
                        stove.CleanStove();
                    }
                }
            
            }
            if (triggerName == "Recievers")
            {

                if (heldItemName == "toastSlice")
                {
                    PlaceHeldItem();
                    GameObject.Find("Recievers/French Toast/toastSlice").SetActive(true);
                }
                if (heldItemName == "friedEgg")
                {
                    PlaceHeldItem();
                    GameObject.Find("Recievers/French Toast/friedEgg").SetActive(true);
                }
            }

            if (triggerName == "Egg")
            {
                PickUpItem(eggPrefab, "egg");
            }


        }
    }
    private void PlaceHeldItem()
    {
        Destroy(heldItem);
        heldItemName = "";
    }
    private void PickUpItem(GameObject itemPrefab, string itemName)
    {
        heldItem = Instantiate(itemPrefab, transform, false);
        heldItem.transform.localPosition = new Vector3(0, 2, 2);
        heldItem.SetActive(true);
        heldItemName = itemName;
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



