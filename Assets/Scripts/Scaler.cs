using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private Vector3 _target;
    [SerializeField] private float _duration;

    private void Start()
    {
        Tween tween = transform.DOScale(_target, _duration);
        tween.SetLoops(-1, LoopType.Yoyo);
    }
}
