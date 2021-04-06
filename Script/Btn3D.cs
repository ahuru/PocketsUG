using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn3D : MonoBehaviour
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

    public void G2()
    {
        StartCoroutine(OpenG2());
    }

    IEnumerator OpenG2()
    {
        Application.OpenURL("https://www.google.com/maps/@-6.3679266,106.8333656,21z");
        yield return new WaitForSeconds(1);
        if (mIsAppLeft)
            mIsAppLeft = false;
        else
            Application.OpenURL("https://www.google.com/maps/@-6.3679253,106.8333964,21z");
    }

    public void G4()
    {
        StartCoroutine(OpenG4());
    }

    IEnumerator OpenG4()
    {
        Application.OpenURL("https://www.google.com/maps/place/Gunadarma+University+Computer+Center/@-6.3682521,106.8333521,19z/data=!4m5!3m4!1s0x0:0xa717192c03b309da!8m2!3d-6.3678709!4d106.8329156");
        yield return new WaitForSeconds(1);
        if (mIsAppLeft)
            mIsAppLeft = false;
        else
            Application.OpenURL("https://www.google.com/maps/@-6.3678672,106.8328955,21z");
    }

    public void G6()
    {
        StartCoroutine(OpenG6());
    }
    IEnumerator OpenG6()
    {
        Application.OpenURL("https://www.google.com/maps/@-6.368499,106.8333837,21z");
        yield return new WaitForSeconds(1);
        if (mIsAppLeft)
            mIsAppLeft = false;
        else
            Application.OpenURL("https://www.google.com/maps/@-6.368473,106.8333173,21z");
    }

    public void GP()
    {
        StartCoroutine(OpenGP());
    }

    IEnumerator OpenGP()
    {
        Application.OpenURL("https://www.google.com/maps/@-6.3684837,106.8329056,21z");
        yield return new WaitForSeconds(1);
        if (mIsAppLeft)
            mIsAppLeft = false;
        else
            Application.OpenURL("https://www.google.com/maps/@-6.368473,106.8333173,21z");
    }   

    public void Perpus()
    {
        StartCoroutine(OpenPerpus());
    }
    
    IEnumerator OpenPerpus()
    {
        Application.OpenURL("https://www.google.com/maps/@-6.3672575,106.8337102,21z");
        yield return new WaitForSeconds(1);
        if (mIsAppLeft)
            mIsAppLeft = false;
        else
            Application.OpenURL("https://www.google.com/maps/@-6.3672162,106.8336599,21z");
    }

    public void G3()
    {
        StartCoroutine(OpenG3());
    }

    IEnumerator OpenG3()
    {
        Application.OpenURL("https://www.google.com/maps/@-6.3672455,106.8334474,21z");
        yield return new WaitForSeconds(1);
        if (mIsAppLeft)
            mIsAppLeft = false;
        else
            Application.OpenURL("https://www.google.com/maps/@-6.3672395,106.8334728,21z");
    }

    public void Loket()
    {
        StartCoroutine(OpenLoket());
    }

    IEnumerator OpenLoket()
    {
        Application.OpenURL("https://www.google.com/maps/@-6.3678946,106.8326702,21z");
        yield return new WaitForSeconds(1);
        if (mIsAppLeft)
            mIsAppLeft = false;
        else
            Application.OpenURL("https://www.google.com/maps/@-6.3672395,106.8334728,21z"); 
    }

    public void Masjid()
    {
        StartCoroutine(OpenMasjid());
    }

    IEnumerator OpenMasjid()
    {
        Application.OpenURL("https://www.google.com/maps/place/Darul+Ilmi+Mosque+-+Gunadarma+University,+D+Campus/@-6.3682524,106.8326286,21z/data=!4m5!3m4!1s0x2e69ec15da4d01cf:0x3f7853fa309c1c50!8m2!3d-6.3681586!4d106.8326694");
        yield return new WaitForSeconds(1);
        if (mIsAppLeft)
            mIsAppLeft = false;
        else
            Application.OpenURL("https://www.google.com/maps/@-6.3682524,106.8326286,21z");
    }
}

