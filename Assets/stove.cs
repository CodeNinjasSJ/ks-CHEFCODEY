using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stove : MonoBehaviour
{
    public stove Stove;
    public GameObject toast;
    public string cookedFood = "";
    // Start is called before the first frame update
    void Start()
    {
        toast.SetActive(false);

    }

    public void CleanStove()
    {
        toast.SetActive(false);
        cookedFood = "";
    }

    public void ToastBread()
    {
        toast.SetActive(true);
        cookedFood = "toast";
    }


}

    

 
   

