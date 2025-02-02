using DynamicData;
using LibNoise;
using LibNoise.Transformer;
using NodeNetwork.Toolkit.ValueNode;
using NoiseNotIncluded.Util;
using NoiseNotIncluded.Yaml.Noise.Nodes;
using ReactiveUI;
using System.Numerics;

namespace NoiseNotIncluded.Nodes.Transformers
{
	public class RotatePointNode : TransformerNode
	{
		protected override Transformer.TransformerType TransformerType => Transformer.TransformerType.RotatePoint;

		public ValueNodeInputViewModel<Vector2> Vector { get; } = NodeHelpers.CreateVector2Editor("Vector", 0f, 0f);

		public RotatePointNode() : base()
		{
			Name = $"RotatePoint_{Uuid()}";

			Inputs.Add(Vector);

			RegisterOutputValue(this.WhenAnyObservable(v => v.SelectNode.ValueChanged,
												 v => v.Vector.ValueChanged,
												 (_1, _2) => GetNewOutput()));
		}

		static RotatePointNode()
		{
			Splat.Locator.CurrentMutable.Register(() => GetNodeView(), typeof(IViewFor<RotatePointNode>));
		}

		protected override IModule GetNewOutput()
		{
			if (SelectNode.Value == null || Vector.Value == null) return null;

			return new RotatePoint(SelectNode.Value, Vector.Value.X, Vector.Value.Y, 0f);
		}

		public override NoiseBase GetYamlNode()
		{
			var result = base.GetYamlNode() as Transformer;
			result.vector = Vector.Value;
			return result;
		}
	}
}
