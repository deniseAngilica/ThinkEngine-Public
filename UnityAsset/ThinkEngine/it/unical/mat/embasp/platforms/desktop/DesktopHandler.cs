﻿using System.Collections.Generic;

namespace EmbASP4Unity.it.unical.mat.embasp.platforms.desktop
{
	using ICallback = EmbASP4Unity.it.unical.mat.embasp.@base.ICallback;
	using Handler = EmbASP4Unity.it.unical.mat.embasp.@base.Handler;
	using InputProgram = EmbASP4Unity.it.unical.mat.embasp.@base.InputProgram;
	using OptionDescriptor = EmbASP4Unity.it.unical.mat.embasp.@base.OptionDescriptor;
	using Output = EmbASP4Unity.it.unical.mat.embasp.@base.Output;

	public class DesktopHandler : Handler
	{
		private readonly DesktopService service;

    public DesktopHandler(DesktopService service) => this.service = service;

    public override void StartAsync(ICallback c, IList<int> program_index, IList<int> option_index)
		{
			IList<InputProgram> input_programs = CollectPrograms(program_index);
			IList<OptionDescriptor> input_options = CollectOptions(option_index);
			service.StartAsync(c, input_programs, input_options);
		}

		public override Output StartSync(IList<int> program_index, IList<int> option_index)
		{
			IList<InputProgram> input_programs = CollectPrograms(program_index);
			IList<OptionDescriptor> input_options = CollectOptions(option_index);
			return service.StartSync(input_programs, input_options);
		}
	}
}