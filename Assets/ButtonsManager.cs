using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEditor;
using com.cyborgAssets.inspectorButtonPro;

public class ButtonsManager : MonoBehaviour
{
    public GameObject watch1;//black
    public GameObject watch2;//white
    public GameObject watch3;//blue

    public GameObject watches;
    public GameObject w;


    public GameObject w1;
    public GameObject w2;
    public GameObject w3;


    private ARTrackedImageManager _arTrackedImageManager;

    private void Awake() 
    {
        _arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
        w = Instantiate(watches);
        w.SetActive(true);
        _arTrackedImageManager.trackedImagePrefab = w;
        //GameObject objectImLookingFor = null;
        

        foreach(Transform g in w.transform)
        {
            if (g.gameObject.name == "apple watch1")
            {
                watch1 = g.gameObject;
            }
            if (g.gameObject.name == "apple watch2")
            {
                watch2 = g.gameObject;
            }
            if (g.gameObject.name == "apple watch3")
            {
                watch3 = g.gameObject;
            }

        }
       // watch1 = w
       // watch1 = GameObject.FindWithTag("watch2");
        //watch1 = GameObject.FindWithTag("watch3");
        /*w2 = Instantiate(watch2);
        w2.SetActive(false);
        w3 = Instantiate(watch3);
        w3.SetActive(false);*/

    }
    [ProButton]
    public void Blue()
    {
        
        watch1.SetActive(false);
        watch2.SetActive(false);
        watch3.SetActive(true);

        _arTrackedImageManager.trackedImagePrefab = watch3;

        //   _arTrackedImageManager.enabled = false;
        // GameObject w3 = Instantiate(watch3);
        //_arTrackedImageManager.trackedImagePrefab = w3;
        //_arTrackedImageManager.enabled = true;
    }

    [ProButton]
    public void Black()
    {

        watch1.SetActive(true);
        watch2.SetActive(false);
        watch3.SetActive(false);
        _arTrackedImageManager.trackedImagePrefab = watch1;
        //_arTrackedImageManager.enabled = false;

        //GameObject w1 = Instantiate(watch1);
        //_arTrackedImageManager.trackedImagePrefab = w1;
        //_arTrackedImageManager.enabled = true;

    }
    [ProButton]
    public void white()
    {
        watch1.SetActive(false);
        watch2.SetActive(true);
        watch3.SetActive(false);
        _arTrackedImageManager.trackedImagePrefab = watch2;
        //  _arTrackedImageManager.enabled = false;

        // GameObject w2 = Instantiate(watch2);
        // _arTrackedImageManager.trackedImagePrefab = w2;
        // _arTrackedImageManager.enabled = true;

    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach (var trackedImage in args.added)
        {
            // _arTrackedImageManager.trackedImagePrefab.SetActive(true);
            //trackedImage.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);

        }

    }

}
