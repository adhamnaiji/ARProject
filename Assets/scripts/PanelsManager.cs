using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PanelsManager : MonoBehaviour
{
    public Animator watch1;
    public Animator watch2;
    public Animator watch3;

    public GameObject buttons;

    public static int currentWatchopened=0;

    //watch1
   public void OpenWatchWindow1()
    {
        watch1.SetBool("watch1open", true);
        currentWatchopened = 1;
        buttons.SetActive(false);
    }

    public void closeWatchWindow1()
    {
        watch1.SetBool("watch1open", false);
        buttons.SetActive(true);
    }

    //watch2
    public void OpenWatchWindow2()
    {
        watch2.SetBool("watch2open", true);
        currentWatchopened = 2;
        buttons.SetActive(false);
    }

    public void closeWatchWindow2()
    {
        watch2.SetBool("watch2open", false);
        buttons.SetActive(true);
    }


    //watch3
    public void OpenWatchWindow3()
    {
        watch3.SetBool("watch3open", true);
        currentWatchopened = 3;
        buttons.SetActive(false);
    }

    public void closeWatchWindow3()
    {
        watch3.SetBool("watch3open", false);
        buttons.SetActive(true);
    }


    public void CloseCurrentWatchPenel()
    {
        if (currentWatchopened == 1)
        {
            closeWatchWindow1();
        }
        if (currentWatchopened == 2)
        {
            closeWatchWindow2();
        }
        if (currentWatchopened == 3)
        {
            closeWatchWindow3();
        }


    }

    //go to the other scene

    public void GoToGPS_scene()
    {
        SceneManager.LoadScene(1);
    }


}
