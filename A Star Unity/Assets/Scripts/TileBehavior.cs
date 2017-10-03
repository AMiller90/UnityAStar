
namespace Assets.Scripts
{
    using UnityEngine;

    /// <summary>
    /// The tile behavior class.
    /// Represents the visuals of tiles.
    /// </summary>
    public class TileBehavior : MonoBehaviour
    {
        /// <summary>
        /// The node reference.
        /// </summary>
        private Node node;

        /// <summary>
        /// Gets or sets the node.
        /// </summary>
        public Node Node
        {
            get
            {
                return this.node;
            }

            set
            {
                this.node = value;
            }
        }

        /// <summary>
        /// The start function.
        /// </summary>
        private void Start()
        {
            // If the node is not walkable..update the sprite renderer to show it as blue
            if(!this.node.IsWalkable)
                this.gameObject.GetComponent<SpriteRenderer>().material.color = Color.blue;
        }
    }
}
