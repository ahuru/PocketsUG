using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public GameObject playbtn, pausebtn;
    public VideoPlayer vplayer;
    public Slider Timer;

    bool isTimerPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        Calculate();
        playbtn.SetActive(false);
        pausebtn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (isTimerPressed)
        {
            vplayer.frame = (long)Timer.value;
        }
        else
        {
            Timer.value = vplayer.frame;
        }
    }

    public void PlayPause()
    {
        if (vplayer.isPlaying)
        {
            vplayer.Pause();
            playbtn.SetActive(true);
            pausebtn.SetActive(false);
        }
        else
        {
            vplayer.Play();
            playbtn.SetActive(false);
            pausebtn.SetActive(true);
        }
    }

    void Calculate()
    {
        int maxframe = (int) vplayer.clip.frameCount;
        Timer.maxValue = maxframe;

    }

    public void OnPointerDown()
    {
        isTimerPressed = true;
    }

    public void OnPointerUp()
    {
        StartCoroutine(PointerUp());
    }

    IEnumerator PointerUp()
    {
        yield return new WaitForSeconds(0.3f);
        isTimerPressed = false;
    }

    public void Backbtn()
    {
        SceneManager.LoadScene("ARview");
    }
}
