using System.Collections;
using System.Collections.Generic;

namespace NeuralNetwork
{
    public class Neuron : IEnumerable<Neuron>
    {
        public List<Neuron> In, Out;

        public IEnumerator<Neuron> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}