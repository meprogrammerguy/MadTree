using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadTree
{
    class Node
    {
        #region Properties
        /// <summary>
        /// Gets or sets the seed.
        /// </summary>
        /// <value>
        /// The seed.
        /// </value>
        public int Seed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the actual score.
        /// </summary>
        /// <value>
        /// The actual score.
        /// </value>
        public int ActualScore
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the predicted score.
        /// </summary>
        /// <value>
        /// The predicted score.
        /// </value>
        public int PredictedScore
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the kenpom team.
        /// </summary>
        /// <value>
        /// The name of the ken pom team.
        /// </value>
        public string KenpomTeamName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the name of the bracket team.
        /// </summary>
        /// <value>
        /// The name of the bracket team.
        /// </value>
        public string BracketTeamName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the winner.
        /// </summary>
        /// <value>
        /// The winner.
        /// </value>
        public Node Winner
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the team a.
        /// </summary>
        /// <value>
        /// The team a.
        /// </value>
        public Node TeamA
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the team b.
        /// </summary>
        /// <value>
        /// The team b.
        /// </value>
        public Node TeamB
        {
            get;
            set;
        }
        #endregion Properties
        #region Public
        public void Display()
        {
            Console.Write("[");
            Console.Write(Seed);
            Console.Write("] ");
        }
        #endregion Public
    }
}
