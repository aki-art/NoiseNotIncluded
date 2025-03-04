﻿using DynamicData;
using LibNoise;
using LibNoise.Filter;
using ReactiveUI;

namespace NoiseNotIncluded.Nodes.Filters
{
	public class BillowNode : FilterNode
	{
		protected override NoiseFilter FilterType => NoiseFilter.Billow;

		// Lacunarity, Frequency, Octaves
		public BillowNode() : base()
		{
			Name = $"Billow_{Uuid()}";

			Inputs.Add(Lacunarity);
			Inputs.Add(Frequency);
			Inputs.Add(Octaves);
		}

		static BillowNode()
		{
			Splat.Locator.CurrentMutable.Register(() => GetNodeView(), typeof(IViewFor<BillowNode>));
		}

		protected override IModule GetNewOutput()
		{
			return new Billow();
		}
	}
}
