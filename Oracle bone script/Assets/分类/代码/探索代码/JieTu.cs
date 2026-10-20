using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JieTu : MonoBehaviour
{
    public int capx = 0;
    public int capy = 0;
    public int capwidth = 700;
    public int capheight = 500;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
   
        public void OnLoginButtonClick()
        {
            //自定义截屏
            StartCoroutine(getScreenTexture());
            //unity 自带截屏，只能是截全屏
            ScreenCapture.CaptureScreenshot("shot.png");
        }
       
    

    IEnumerator getScreenTexture()
    {
        yield return new WaitForEndOfFrame();
        //需要正确设置好图片保存格式
        Texture2D t = new Texture2D(capwidth, capheight, TextureFormat.RGB24, true);
        //按照设定区域读取像素；注意是以左下角为原点读取
        t.ReadPixels(new Rect(capx, capy, capwidth, capheight), 0, 0, false);
        t.Apply();
        //二进制转换
        byte[] byt = t.EncodeToPNG();
        System.IO.File.WriteAllBytes(Application.dataPath + Time.time + ".png", byt);
    }

}