using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioSource level1Music;
    public AudioSource scoreMusic;
    // Start is called before the first frame update
    
    public void Level1Music()
    {
        level1Music.Play();
    }

    public void ScoreMusic()
    {
        scoreMusic.Play();
    }
}
