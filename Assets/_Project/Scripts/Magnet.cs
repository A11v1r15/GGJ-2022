using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Magnet : MonoBehaviour
{
    [SerializeField]
    private Polarity polarity = Polarity.NEUTRAL;
    [SerializeField]
    private float radius = 2f;

    private Rigidbody2D rigidbody;

    #nullable enable
    private static Magnet[]? allMagnets;
    public static Magnet[]? GetAllMagnets => allMagnets ??= FindObjectsOfType<Magnet>();
    #nullable disable

    public Rigidbody2D GetRigidbody => rigidbody ??= GetComponent<Rigidbody2D>();
    public float GetRadius => radius;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Magnet magnet in GetAllMagnets)
        {
            if(
             this.polarity != Polarity.NEUTRAL &&
             this != magnet &&
             magnet.polarity != Polarity.NEUTRAL &&
             Vector3.Distance(transform.position, magnet.transform.position) < this.GetRadius + magnet.GetRadius
             ){
                Vector3 direction = (transform.position - magnet.transform.position).normalized;
                GetRigidbody.AddForce(direction * Vector3.Distance(transform.position, magnet.transform.position) * ((this.polarity == magnet.polarity) ? 1 : -1));
            }
        }
    }

#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        switch (polarity)
        {
            case Polarity.NORTH:
            UnityEditor.Handles.color = Color.red;
            break;
            case Polarity.SOUTH:
            UnityEditor.Handles.color = Color.blue;
            break;
            case Polarity.NEUTRAL:
            default:
            UnityEditor.Handles.color = Color.white;
            break;
        }
        UnityEditor.Handles.DrawWireDisc(transform.position, Vector3.back, radius);
    }
#endif
}

enum Polarity{
    NEUTRAL,
    NORTH,
    SOUTH
}