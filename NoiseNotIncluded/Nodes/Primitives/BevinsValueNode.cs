﻿using DynamicData;
using LibNoise;
using LibNoise.Primitive;
using ReactiveUI;

namespace NoiseNotIncluded.Nodes.Primitives
{
	public class BevinsValueNode : PrimitiveNode
	{
		protected override NoisePrimitive PrimitiveType => NoisePrimitive.BevinsValue;

		public BevinsValueNode() : base()
		{
			Name = $"BevinsValue_{Uuid()}";

			Inputs.Add(Quality);
			Inputs.Add(Seed);
		}

		static BevinsValueNode()
		{
			Splat.Locator.CurrentMutable.Register(() => GetNodeView(), typeof(IViewFor<BevinsValueNode>));
		}

		protected override IModule GetNewOutput()
		{
			if (Seed.Value == null || Quality.Value == null) return null;
			return new BevinsValue(Seed.Value.Value, (NoiseQuality)Quality.Value);
		}
	}
}
