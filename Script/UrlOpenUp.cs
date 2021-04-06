using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlOpenUp : MonoBehaviour
{
    public bool mIsAppLeft;
   void OnApplicationFocus(bool hasFocus)
    {
        mIsAppLeft = !hasFocus;
    }
    void OnApplicationPause(bool pauseStatus)
    {
        mIsAppLeft = pauseStatus;
    }

    public void Staff()
    {
        StartCoroutine(OpenStaff());
    }

    IEnumerator OpenStaff()
    {
        Application.OpenURL("http://staffsite.gunadarma.ac.id/");
        yield return new WaitForSeconds(1);
        if (mIsAppLeft)
            mIsAppLeft = false;
        else
            Application.OpenURL("http://staffsite.gunadarma.ac.id/index2.php");
    }

    public void Student()
    {
        StartCoroutine(OpenStudent());
    }

    IEnumerator OpenStudent()
    {
        Application.OpenURL("https://studentsite.gunadarma.ac.id/index.php/site/index");
        yield return new WaitForSeconds(1);
        if (mIsAppLeft)
            mIsAppLeft = false;
        else
            Application.OpenURL("https://studentsite.gunadarma.ac.id/index.php/site/news");
    }

    public void Lab()
    {
        StartCoroutine(OpenLab());
    }
    IEnumerator OpenLab()
    {
        Application.OpenURL("https://lepkom.gunadarma.ac.id/");
        yield return new WaitForSeconds(1);
        if (mIsAppLeft)
            mIsAppLeft = false;
        else
            Application.OpenURL("https://lepkom.gunadarma.ac.id/?stateid=jadwal");
    }

}
