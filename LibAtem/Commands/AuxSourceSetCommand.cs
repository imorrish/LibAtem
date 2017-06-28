﻿using LibAtem.Common;

namespace LibAtem.Commands
{
    [CommandName("CAuS")]
    public class AuxSourceSetCommand : ICommand
    {
        public uint Id { get; set; }
        public VideoSource Source { get; set; }

        public void Serialize(CommandBuilder cmd)
        {
            cmd.AddBoolArray(true);
            cmd.AddUInt8(Id);
            cmd.AddUInt16((int)Source);
        }

        public void Deserialize(ParsedCommand cmd)
        {
            cmd.Skip();

            Id = cmd.GetUInt8();
            Source = (VideoSource) cmd.GetUInt16();
        }
    }
}