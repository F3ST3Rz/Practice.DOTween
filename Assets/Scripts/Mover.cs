using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3[] _waypoints;
    [SerializeField] private float _duration;

    private void Start()
    {
        Tween tween = transform.DOPath(_waypoints, _duration);
        tween.SetLoops(-1);
        tween.SetEase(Ease.Linear);
    }
}
