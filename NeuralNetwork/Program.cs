using System.Collections.Generic;

namespace NeuralNetwork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var neuron1 = new Neuron();
            var neuron2 = new Neuron();
            var layer1 = new NeuronLayer(3);
            var layer2 = new NeuronLayer(4);

            neuron1.ConnectTo(neuron2);
            neuron1.ConnectTo(layer1);
            layer2.ConnectTo(neuron1);
            layer1.ConnectTo(layer2);
        }
    }

    public static class ExtensionMethods
    {
        public static void ConnectTo(
            this IEnumerable<Neuron> self,
            IEnumerable<Neuron> other
        )
        {
            if (ReferenceEquals(self, other)) return;

            foreach (var from in self)
            {
                foreach (var to in other)
                {
                    from.Out.Add(to);
                    to.In.Add(from);
                }
            }
        }
    }
}