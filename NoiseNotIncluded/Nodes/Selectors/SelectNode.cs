﻿using ReactiveUI;

namespace NoiseNotIncluded.Nodes.Selectors
{
	public class SelectNode : SelectorNode
	{
		public SelectNode() : base()
		{
			Name = "Select";
		}

		static SelectNode()
		{
			Splat.Locator.CurrentMutable.Register(() => GetNodeView(), typeof(IViewFor<SelectNode>));
		}
	}
}
