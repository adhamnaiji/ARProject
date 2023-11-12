using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;


[RequireComponent(typeof(ARTrackedImageManager))]
public class ImageRecognition : MonoBehaviour
{

    public GameObject watch1;//black
    public GameObject watch2;//white
    public GameObject watch3;//blue

  

     public GameObject w1;
    public GameObject w2;
    public GameObject w3;


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
        foreach(var trackedImage in args.added)
        {
           // _arTrackedImageManager.trackedImagePrefab.SetActive(true);
           // trackedImage.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            ui.SetActive(true);
            trackedImage.transform.position = trackedImage.transform.position;
            trackedImage.transform.rotation = trackedImage.transform.rotation;

        }
        
    }

    
}
