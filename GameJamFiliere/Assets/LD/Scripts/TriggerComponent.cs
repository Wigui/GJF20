using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerComponent : MonoBehaviour
{
    /// <summary>
    /// Tags autorisés à déclencer le trigger
    /// </summary>
    [SerializeField]
    private string _tagFilter;

    /// <summary>
    /// Evènements à déclencher lors d'un trigger enter
    /// </summary>
    [SerializeField]
    private UnityEvent _onTriggerEnter;

    /// <summary>
    /// Evènements à déclencher lors d'un trigger stay
    /// </summary>
    [SerializeField]
    private UnityEvent _onTriggerStay;

    /// <summary>
    /// Evènements à déclencher lors d'un trigger exit
    /// </summary>
    [SerializeField]
    private UnityEvent _onTriggerExit;

    [SerializeField]
    private bool _destroyActorOnTrigger;

    [SerializeField]
    private bool _destroyVictimOnTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != _tagFilter)
            return;

        _onTriggerEnter?.Invoke();

        if (_destroyActorOnTrigger)
            Destroy(collision.gameObject);

        if (_destroyVictimOnTrigger)
            Destroy(gameObject);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag != _tagFilter)
            return;

        _onTriggerStay?.Invoke();

        // if (_destroyActorOnTrigger)
        // Destroy(collision.gameObject);

        //if (_destroyVictimOnTrigger)
        // Destroy(gameObject);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag != _tagFilter)
            return;

        _onTriggerExit?.Invoke();

        // if (_destroyActorOnTrigger)
        // Destroy(collision.gameObject);

        //if (_destroyVictimOnTrigger)
        // Destroy(gameObject); 
    }
}
