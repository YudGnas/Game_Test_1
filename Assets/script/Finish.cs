using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class Finish : MonoBehaviour
{
    public Node _node;
    private bool hasFinish;
    public int Level;
    public MeshRenderer _renderer;
    public Sound_effect _effect;
    public AudioSource _audio;
    public Image fadeImage;
    public float duration = 4f;
    void Start()
    {   
        
        if(fadeImage.enabled == false)
        {
            fadeImage.enabled = true;
            fadeImage.DOFade(0f, duration).SetEase(Ease.InOutQuad);
        }
        
    }
    void Update()
    {   
         
        if (Level <=2)
        {
            if (_node._player != null && hasFinish == false)
            {   
                  StartCoroutine(HadFinish());
            }
        }
        else
        {
            if (_node._player != null && hasFinish == false && _node._player._renderer.material.color == _renderer.material.color )
            {
                StartCoroutine(HadFinish());
            }
        }
    }

    IEnumerator HadFinish()
    {
        Debug.Log("Finish!!!");
        hasFinish = true;
        _effect.Finish();
        yield return new WaitForSeconds(_audio.clip.length);
        fadeImage.DOFade(1f, duration).SetEase(Ease.InOutQuad).OnComplete(() =>
        {
            SceneManager.LoadSceneAsync(Level);
        });
    }
}
