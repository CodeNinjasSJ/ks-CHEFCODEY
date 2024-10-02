using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stove : MonoBehaviour
{
    public stove Stove;
    public GameObject toast;
    public GameObject friedEgg;
    public string cookedFood = "";
    public ParticleSystem smoke;
    public ParticleSystem complete;
    public bool isCooking = false;
    // Start is called before the first frame update
    void Start()
    {
        toast.SetActive(false);

    }

    public void CleanStove()
    {
        toast.SetActive(false);
        cookedFood = "";
        complete.Stop();
    }

    public void ToastBread()
    {
        isCooking = true;
        smoke.Play();
        toast.SetActive(true);
        cookedFood = "toast";
        Invoke("CompleteCooking", 8f);
    }

    public void FryEgg()
    {
        isCooking = true;
        smoke.Play();
        toast.SetActive(true);
        cookedFood = "friedEgg";
        Invoke("CompleteCooking", 6f);
    }
    private void CompleteCooking()
    {
        isCooking = false;
        smoke.Stop();
        complete.Play();
    }
}

    

 
   

