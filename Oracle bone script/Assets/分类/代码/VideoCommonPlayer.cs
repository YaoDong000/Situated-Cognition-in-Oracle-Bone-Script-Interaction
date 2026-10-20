using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoCommonPlayer : MonoBehaviour
{

    public VideoPlayer vPlayer;

    public object frame { get; private set; }
    
    void Start()
    {
        // Will attach a VideoPlayer to the main camera.
        GameObject camera = GameObject.Find("Main Camera");

        // Play on awake defaults to true. Set it to false to avoid the url set
        // below to auto-start playback since we're in Start().
        vPlayer.playOnAwake = true;

        // By default, VideoPlayers added to a camera will use the far plane.
        // Let's target the near plane instead.
        vPlayer.renderMode = UnityEngine.Video.VideoRenderMode.CameraNearPlane;

        // This will cause our scene to be visible through the video being played.
        vPlayer.targetCameraAlpha = 1.0F;

        // Skip the first 100 frames.
        vPlayer.frame = 1;

        // Restart from beginning when done.
        vPlayer.isLooping = false;

        // Each time we reach the end, we slow down the playback by a factor of 10.
        vPlayer.loopPointReached += EndReached;



        // Start playback. This means the VideoPlayer may have to prepare (reserve
        // resources, pre-load a few frames, etc.). To better control the delays
        // associated with this preparation one can use videoPlayer.Prepare() along with
        // its prepareCompleted event.

    }

    /*void OnGUI()
    {
        if (GUI.Button(new Rect(300, 20, 100, 100), "播放/继续"))
        {
            //播放/继续播放视频
            if (!vPlayer.isPlaying)
            {
                vPlayer.Play();
            }
        }

        if (GUI.Button(new Rect(450, 20, 100, 100), "暂停播放"))
        {
            //暂停播放
            vPlayer.Pause();
        }

        if (GUI.Button(new Rect(600, 20, 100, 100), "停止播放"))
        {
            //停止播放
            vPlayer.Stop();
        }
    }
    */

    void EndReached(VideoPlayer vPlayer)
    {
        
        Debug.Log("End reached!" + vPlayer.clip);
    }
    
    void Update()
    {
       Debug.Log("Frame " + vPlayer.frame);
        
    }
}

