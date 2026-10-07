namespace HydraMenu.modules.troll
{
	internal class CrashLobby : Module
	{
		public CrashLobby() : base("CrashLobby") { }

		private void OnGameStart()
		{
			PlayerControl.LocalPlayer.CmdReportDeadBody(null);
			Hydra.notifications.Send("Lobby Fucker", "The lobby has been fucked.");
		}

		protected override void OnEnable()
		{
			Hydra.notifications.Send("Lobby Fucker", "Fuck Lobby has been enabled. This will fuck the lobby as soon as the game starts.");

			EventCoordinator.OnGameStart += OnGameStart;
		}

		protected override void OnDisable()
		{
			EventCoordinator.OnGameStart -= OnGameStart;
		}
	}
}
