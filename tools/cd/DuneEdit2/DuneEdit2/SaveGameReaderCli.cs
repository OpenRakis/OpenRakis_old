using DuneEdit2.Parsing;

using System.Text;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("DuneEdit2.UnitTests")]

namespace DuneEdit2
{
    internal class SaveGameReaderCli
    {
        private readonly SaveGameReader _reader;

        public SaveGameReaderCli(Options options)
        {
            _reader = new SaveGameReader(options.InputSaveGameFile);
        }

        public string GetStandardOutput()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Player information");
            stringBuilder.AppendLine("------------------");
            stringBuilder.AppendLine(GetPlayerSpice());
            stringBuilder.AppendLine(GetPlayerContactDistance());
            stringBuilder.AppendLine(GetPlayerCharisma());
            stringBuilder.AppendLine(GetDateAndTime());
            return stringBuilder.ToString();
        }

        internal string GetDateAndTime() => $"Date and Time: {_reader.GetDateForUI()} ({_reader.GetDateHexValue()}) - Position: {_reader.GetDatePosition()}";

        internal string GetPlayerCharisma() => $"Charisma: {_reader.GetPlayerCharismaForUI()} ({_reader.GetPlayerCharismaHexValue()}) - Position: {_reader.GetPlayerCharismaPosition()}";

        internal string GetPlayerContactDistance() => $"Contact distance: {_reader.GetPlayerContactDistanceForUI()} ({_reader.GetPlayerContactDistanceHexValue()}) - Position: {_reader.GetPlayerContactDistancePosition()}";

        internal string GetPlayerSpice() => $"Spice: {_reader.GetPlayerSpiceForUI()} Kg ({_reader.GetPlayerSpiceHexValue()}) - Position: {_reader.GetPlayerSpiceHexPosition()}";
    }
}