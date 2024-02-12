using System.Collections;
using UnityEngine;

public class SampleScenControler : MonoBehaviour
{
    public GameObject Apple;
    public GameObject LinkControler;
    public GameObject Nyuton;

    public Animator animator;
    public Animator NyutonAnim;

    public AudioClip LinkAudio;
    public AudioSource NyutonAudio;

    void Start()
    {
        StartCoroutine(controller());
    }

    IEnumerator controller()
    {
        yield return new WaitForSeconds(52.2f);

        Nyuton.SetActive(true);
        NyutonAnim.SetInteger("Nyuton", 1);
        yield return new WaitForSeconds(2.2f);

        NyutonAudio.Play();
        NyutonAnim.SetInteger("Nyuton", 2);
        yield return new WaitForSeconds(13);
        Apple.SetActive(true);
    }
}