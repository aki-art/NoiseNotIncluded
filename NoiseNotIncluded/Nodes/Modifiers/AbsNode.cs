﻿using LibNoise;
using LibNoise.Modifier;
using NoiseNotIncluded.Yaml.Noise.Nodes;
using ReactiveUI;
using System.Reactive.Linq;

namespace NoiseNotIncluded.Nodes.Modifiers
{
	public class AbsNode : ModifierNode
	{
		protected override Modifier.ModifyType ModifyType => Modifier.ModifyType.Abs;

		public AbsNode() : base()
		{
			Name = $"Abs_{Uuid()}";

			RegisterOutputValue(NodeInput.ValueChanged.Select(v => GetNewOutput()));
		}

		static AbsNode()
		{
			Splat.Locator.CurrentMutable.Register(() => GetNodeView(), typeof(IViewFor<AbsNode>));
		}

		protected override IModule GetNewOutput()
		{
			if (NodeInput.Value == null) return null;
			return new Abs(NodeInput.Value);
		}
	}
}
