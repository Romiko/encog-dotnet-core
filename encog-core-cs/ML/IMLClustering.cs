//
// Encog(tm) Core v3.1 - .Net Version
// http://www.heatonresearch.com/encog/
//
// Copyright 2008-2012 Heaton Research, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//   
// For more information on Heaton Research copyrights, licenses 
// and trademarks visit:
// http://www.heatonresearch.com/copyright
//
namespace Encog.ML
{
    /// <summary>
    /// A machine learning method that is used to break data into clusters.  The 
    /// number of clusters is usually defined beforehand.  This differs from 
    /// the MLClassification method in that the data is clustered as an entire 
    /// group.  If additional data must be clustered later, the entire group 
    /// must be reclustered.
    /// </summary>
    ///
    public interface IMLClustering : IMLMethod
    {
        /// <value>The clusters.</value>
        IMLCluster[] Clusters { get; }

        /// <summary>
        /// Perform the training iteration.
        /// </summary>
        ///
        void Iteration();

        /// <summary>
        /// Perform the specified number of training iterations.
        /// </summary>
        ///
        /// <param name="count">The number of training iterations.</param>
        void Iteration(int count);


        /// <returns>The number of clusters.</returns>
        int Count { get;  }
    }
}
