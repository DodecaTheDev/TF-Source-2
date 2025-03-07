﻿using Sandbox;
using Amper.FPS;

namespace TFS2;

#region Player

[EventDispatcherEvent]
public class PlayerSpawnEvent : DispatchableEventBase
{
	public Client Client { get; set; }
	public TFTeam Team { get; set; }
	public PlayerClass Class { get; set; }
}

[EventDispatcherEvent]
public class PlayerDeathEvent : DispatchableEventBase
{
	public Client Victim { get; set; }
	public Client Attacker { get; set; }
	public Client Assister { get; set; }
	public WeaponData Weapon { get; set; }
	public DamageFlags Flags { get; set; }
	public Vector3 Position { get; set; }
	public float Damage { get; set; }
}

[EventDispatcherEvent]
public class PlayerHurtEvent : DispatchableEventBase
{
	public Client Victim { get; set; }
	public Client Attacker { get; set; }
	public Client Assister { get; set; }
	public WeaponData Weapon { get; set; }
	public DamageFlags Flags { get; set; }
	public Vector3 Position { get; set; }
	public float Damage { get; set; }
}

[EventDispatcherEvent]
public class PlayerChangeClassEvent : DispatchableEventBase
{
	public Client Client { get; set; }
	public PlayerClass Class { get; set; }
}

[EventDispatcherEvent]
public class PlayerChangeTeamEvent : DispatchableEventBase
{
	public Client Client { get; set; }
	public TFTeam Team { get; set; }
}

[EventDispatcherEvent]
public class PlayerRegenerateEvent : DispatchableEventBase
{
	public Client Client { get; set; }
}

#endregion

#region Game

[EventDispatcherEvent]
public class GameRestartEvent : DispatchableEventBase { }

[EventDispatcherEvent]
public class GameOverEvent : DispatchableEventBase { }

#endregion

#region Control Points

[EventDispatcherEvent]
public class ControlPointCapturedEvent : DispatchableEventBase
{
	public ControlPoint Point { get; set; }
	public TFTeam NewTeam { get; set; }
	public Client[] Cappers { get; set; }
}

#endregion
