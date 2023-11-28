using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;


[RequireComponent(typeof(ARTrackedImageManager))]
public class ImageRecognition : MonoBehaviour
{
    //watch1
    public Material black;
    public Material blue;
    //
    public Material red;
    //
    public Material white;


    public GameObject watch1;
    public GameObject watch2;
    public GameObject watch3;

    public GameObject Watches_Together;


    private ARTrackedImageManager _arTrackedImageManager;

    public GameObject ui;

    private void Awake()
    {
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
        
    }

    public void OnEnable()
    {
        _arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable()
    {
        _arTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        
            ui.SetActive(true);
            Watches_Together= _arTrackedImageManager.trackedImagePrefab ;

            //parcourir et affecter 
            foreach (var trackedImage in _arTrackedImageManager.trackables)
            {
                foreach (Transform trackedImagee in trackedImage.transform)
                {

                   // Debug.Log(trackedImagee);

                    if (trackedImagee.gameObject.name == "watch1")
                    {
                        watch1 = trackedImagee.gameObject;
                    }
                    if (trackedImagee.gameObject.name == "watch2")
                    {
                        watch2 = trackedImagee.gameObject;
                    }
                    if (trackedImagee.gameObject.name == "watch3")
                    {
                        watch3 = trackedImagee.gameObject;
                    }
                }
            }       
        
    }

    public void OpenWatch1()
    {
       
        watch2.SetActive(false);
        watch3.SetActive(false);
        watch1.SetActive(true);
       
        //_arTrackedImageManager.trackedImagePrefab = Watches_Together;
    }

    public void OpenWatch2()
    {
        watch1.SetActive(false);
        watch3.SetActive(false);
        watch2.SetActive(true);
        _arTrackedImageManager.trackedImagePrefab = Watches_Together;
    }

    public void OpenWatch3()
    {
        watch2.SetActive(false);
        watch3.SetActive(true);
        watch1.SetActive(false);
        _arTrackedImageManager.trackedImagePrefab = Watches_Together;
    }

    

    //buttons change color

    //watch1
    public void ChangeWatch1ToBlack()
    {
        
        foreach(Transform watch in watch1.transform)
        {
            if(watch.gameObject.name== "Band")
            {
                watch.GetComponent<Renderer>().material = black;
            }
        }
    }
    public void ChangeWatch1ToBlue()
    {
        foreach (Transform watch in watch1.transform)
        {
            if (watch.gameObject.name == "Band")
            {
                watch.GetComponent<Renderer>().material = blue;
            }
        }
    }

    //watch2

    public void ChangeWatch2ToBlack()
    {

        foreach (Transform watch in watch2.transform)
        {
            if (watch.gameObject.name == "Band")
            {
                watch.GetComponent<Renderer>().material = black;
            }
        }
    }

    public void ChangeWatch2ToRed()
    {

        foreach (Transform watch in watch2.transform)
        {
            if (watch.gameObject.name == "Band")
            {
                watch.GetComponent<Renderer>().material = red;
            }
        }
    }


    //watch3
    
public void ChangeWatch3ToBlack()
    {

        foreach (Transform watch in watch3.transform)
        {
            if (watch.gameObject.name == "Base_Housing")
            {
                watch.GetComponent<Renderer>().material = black;
            }
        }
    }


    public void ChangeWatch3Towhite()
    {

        foreach (Transform watch in watch3.transform)
        {
            if (watch.gameObject.name == "Base_Housing")
            {
                watch.GetComponent<Renderer>().material = white;
            }
        }
    }


}
