using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
public class Magnet : MonoBehaviour
{
    [SerializeField]
    private Polarity _polarity = Polarity.NEUTRAL;
    [SerializeField]
    private float _radius = 2f;

    private Rigidbody2D _rigidbody;
    private CircleCollider2D _collider;

    #nullable enable
    private static Magnet[]? allMagnets;
    public static Magnet[]? GetAllMagnets => allMagnets ??= FindObjectsOfType<Magnet>();
    #nullable disable

    public Rigidbody2D GetRigidbody => _rigidbody ??= GetComponent<Rigidbody2D>();
    public CircleCollider2D GetCollider => _collider ??= GetComponent<CircleCollider2D>();
    public float GetRadius => _radius;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        foreach (Magnet magnet in GetAllMagnets)
        {
            if(
             this._polarity != Polarity.NEUTRAL &&
             this != magnet &&
             magnet._polarity != Polarity.NEUTRAL &&
             Vector3.Distance(transform.position, magnet.transform.position) < this.GetRadius
             ){
                Vector3 direction = (transform.position - magnet.transform.position).normalized;
                GetRigidbody.AddForce(direction * 100f * (_radius - DistanceTo(magnet)) * ((this._polarity == magnet._polarity) ? 1 : -1));
                Debug.Log(gameObject.name + " " + (_radius - DistanceTo(magnet)) * ((this._polarity == magnet._polarity) ? 1 : -1));
            }
        }
    }

    public void Henshin(){
        switch(_polarity){
            case Polarity.NORTH:
            _polarity = Polarity.SOUTH;
            break;
            case Polarity.SOUTH:
            case Polarity.NEUTRAL:
            default:
            _polarity = Polarity.NORTH;
            break;
        }
    }

    public float DistanceTo(Magnet other){
        return Vector3.Distance(transform.position, other.transform.position) - GetCollider.radius - other.GetCollider.radius;
    }

#if UNITY_EDITOR
    void OnDrawGizmos()
    {
        switch (_polarity)
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
        UnityEditor.Handles.DrawWireDisc(transform.position, Vector3.back, _radius);
    }
#endif
}

enum Polarity{
    NEUTRAL,
    NORTH,
    SOUTH
}