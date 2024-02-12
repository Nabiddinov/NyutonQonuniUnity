using System.Collections;
using UnityEngine;

public class Change2 : MonoBehaviour
{
    public Animator LinkAnim;

    void Start()
    {
        StartCoroutine(AnimationController());
    }

    IEnumerator AnimationController()
    {
        yield return new WaitForSeconds(36f);
        LinkAnim.SetInteger("Link", 1);
    }
}