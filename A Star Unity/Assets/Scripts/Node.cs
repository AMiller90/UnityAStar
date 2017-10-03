
namespace Assets.Scripts
{
    using System.Collections.Generic;

    /// <summary>
    /// The node class.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The neighbors reference.
        /// </summary>
        private readonly List<Node> neighbors = new List<Node>();

        /// <summary>
        /// The x and y reference.
        /// </summary>
        private int x, y;

        /// <summary>
        /// The walkable reference.
        /// </summary>
        private bool walkable;

        /// <summary>
        /// The g and h cost references.
        /// </summary>
        private int gCost, hCost;

        /// <summary>
        /// The parent node reference.
        /// </summary>
        private Node parent;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="xPos">
        /// The x position.
        /// </param>
        /// <param name="yPos">
        /// The y position.
        /// </param>
        /// <param name="isWalkable">
        /// The is walkable.
        /// </param>
        public Node(int xPos, int yPos, bool isWalkable)
        {
            this.x = xPos;
            this.y = yPos;
            this.walkable = isWalkable;
        }

        /// <summary>
        /// Gets or sets the x position.
        /// </summary>
        public int XPosition
        {
            get
            {
                return this.x;
            }

            set
            {
                this.x = value;
            }
        }

        /// <summary>
        /// Gets or sets the y position.
        /// </summary>
        public int YPosition
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether is walkable.
        /// </summary>
        public bool IsWalkable
        {
            get
            {
                return this.walkable;
            }

            set
            {
                this.walkable = value;
            }
        }

        /// <summary>
        /// Gets or sets the h cost.
        /// </summary>
        public int HCost
        {
            get
            {
                return this.hCost;
            }

            set
            {
                this.hCost = value;
            }
        }

        /// <summary>
        /// Gets or sets the g cost.
        /// </summary>
        public int GCost
        {
            get
            {
                return this.gCost;
            }

            set
            {
                this.gCost = value;
            }
        }

        /// <summary>
        /// Gets the f cost.
        /// </summary>
        public int FCost
        {
            get
            {
                return this.gCost + this.hCost;
            }
        }

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        public Node Parent
        {
            get
            {
                return this.parent;
            }

            set
            {
                this.parent = value;
            }
        }

        /// <summary>
        /// The get neighbors function.
        /// Returns the list of neighbors.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<Node> GetNeighbors()
        {
            // Make sure list is already empty
            this.neighbors.Clear();

            // Loop through the neighbors
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    // If i and j = 0...then this is the current node trying to find its neighbors..
                    // Just continue or else it will check itself
                    if (i == 0 && j == 0)
                        continue;

                    // Get the node at the position from the grid
                    Node neighbor = GridManager.Instance.GetNode(this.x + i, this.y + j);

                    // If its not walkable then continue to next node
                    if (!neighbor.IsWalkable)
                        continue;

                    // Add the node to the neighbors list
                    this.neighbors.Add(neighbor);
                }
            }

            // Return the neighbors list
            return this.neighbors;
        }
    }
}
