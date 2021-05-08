using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{   
    public ParticleSystem particleFinish;
    public ParticleSystem particleCrash;
    public float delayStart;
    public AudioClip audioCrash;
    public AudioClip audioFinish;
    bool isTransitioning  = false;
    AudioSource audioSource;


    private void Start() {
        audioSource= GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision other) {

        if(isTransitioning) return;
           
               switch(other.gameObject.tag){
            case "Finish":
                NextLevel();
                break;
            case "Start":break;
            default:
                Crash();
                break;
        }
        
        
    }

    void Crash(){
        isTransitioning=true;   
        particleCrash.Play();
        GetComponent<movePlayer>().enabled = false;
              audioSource.PlayOneShot(audioCrash);

           
                Invoke("RestartScene",delayStart);
    }
    void NextLevel(){
        isTransitioning=true;   
        particleFinish.Play();
        GetComponent<movePlayer>().enabled = false;
      audioSource.PlayOneShot(audioFinish);
        Invoke("LoadNextScene",delayStart);
    }
    void LoadNextScene()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex+1;
        if(nextScene == SceneManager.sceneCount){
            nextScene=0;
        }
        SceneManager.LoadScene(nextScene);

    }
    void RestartScene()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
