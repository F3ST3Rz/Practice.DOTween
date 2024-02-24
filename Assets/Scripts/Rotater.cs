using DG.Tweening;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    [SerializeField] private Vector3 _target;
    [SerializeField] private float _duration;

    private void Start()
    {
        Tween tween = transform.DORotate(_target, _duration);
        tween.SetLoops(-1, LoopType.Yoyo);
    }
}
