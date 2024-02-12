using System.Collections;
using UnityEngine;

public class Scen3Controller : MonoBehaviour
{
    public GameObject Model;
    public Animator LinkAnim;
    public AudioSource audioClip;
    public AudioSource audioClip2;

    void Start()
    {
        StartCoroutine(modelController());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            Chiqish();
        }
    }
    IEnumerator modelController()
    {
        yield return new WaitForSeconds(8);
        Model.SetActive(true);
        LinkAnim.SetInteger("Link", 1);
    }

    public void Chiqish()
    {
        audioClip2.Stop();
        LinkAnim.SetInteger("Link", 2);
        audioClip.Play();
        StartCoroutine(Kutish(6.5f));
    }

    IEnumerator Kutish(float a)
    {
        yield return new WaitForSeconds(a);
        LinkAnim.SetInteger("Link", 1);
    }
}