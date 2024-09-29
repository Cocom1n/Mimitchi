using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TvController : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public VideoClip[] listaVideos;

    public SpriteRenderer pantallaTv;

    void Start()
    {
        pantallaTv.color = Color.black;
    }
    public void EncenderTv()
    {
        pantallaTv.color = Color.white;
        int i = Random.Range(0, listaVideos.Length);
        videoPlayer.clip = listaVideos[i];
        videoPlayer.Play();
        StartCoroutine(TemporizadorTv(5f));
        
    }

    private IEnumerator TemporizadorTv(float tiempo)
    {
        yield return new WaitForSeconds(tiempo);
        videoPlayer.Stop();
        pantallaTv.color = Color.black;
    }

    public void ApagarTv()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Stop();
            pantallaTv.color = Color.black;
        }
    }

}
