﻿using DynamicData;
using LibNoise;
using LibNoise.Filter;
using ReactiveUI;

namespace NoiseNotIncluded.Nodes.Filters
{
	public class RidgedMultiFractalNode : FilterNode
	{
		protected override NoiseFilter FilterType => NoiseFilter.RidgedMultiFractal;

		// All args

		public RidgedMultiFractalNode() : base()
		{
			Name = $"RidgedMultiFractal_{Uuid()}";

			Inputs.Add(Lacunarity);
			Inputs.Add(Frequency);
			Inputs.Add(Octaves);
			Inputs.Add(Offset);
			Inputs.Add(Gain);
		}

		static RidgedMultiFractalNode()
		{
			Splat.Locator.CurrentMutable.Register(() => GetNodeView(), typeof(IViewFor<RidgedMultiFractalNode>));
		}

		protected override IModule GetNewOutput()
		{
			return new RidgedMultiFractal();
		}
	}
}
