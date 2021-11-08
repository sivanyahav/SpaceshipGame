using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyHeart : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;

    void start(){
        //scoreField = GetComponent<NumberField>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
                Destroy(this.gameObject);
                GameControlScript.health += 1;
        }
    }
}
