﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Const;

namespace Melia.Shared.World.ObjectProperties
{
	public class Properties
	{
		private readonly Dictionary<int, IProperty> _properties = new Dictionary<int, IProperty>();

		/// <summary>
		/// Returns the byte size of all properties, as they would take
		/// in a packet.
		/// </summary>
		/// XXX: Could be cached if performance is a problem.
		public int Size { get { lock (_properties) return _properties.Values.Sum(a => a.Size); } }

		/// <summary>
		/// Returns the property with the given property id,
		/// or null if it doesn't exist.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <returns></returns>
		public IProperty Get(int propertyId)
		{
			lock (_properties)
			{
				if (!_properties.TryGetValue(propertyId, out var property))
					return null;

				return property;
			}
		}

		/// <summary>
		/// Returns list of all set properties.
		/// </summary>
		/// <returns></returns>
		public IProperty[] GetAll()
		{
			lock (_properties)
				return _properties.Values.ToArray();
		}

		/// <summary>
		/// Returns list of all set properties.
		/// </summary>
		/// <returns></returns>
		public IProperty[] GetAll(params int[] propertyIds)
		{
			lock (_properties)
				return _properties.Values.Where(a => propertyIds.Contains(a.Id)).ToArray();
		}

		/// <summary>
		/// Sets the given propery's value.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="value"></param>
		public void Set(int propertyId, float value)
		{
			if (GetPropertyType(propertyId) != PropertyType.Float)
				throw new ArgumentException($"Property '{propertyId}' is not supposed to be a float, or is missing from the property type switch.");

			lock (_properties)
			{
				if (!_properties.TryGetValue(propertyId, out var property))
					_properties[propertyId] = new FloatProperty(propertyId, value);
				else
					(property as FloatProperty).Value = value;
			}
		}

		/// <summary>
		/// Sets the given propery's value.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="value"></param>
		public void Set(int propertyId, string value)
		{
			if (GetPropertyType(propertyId) != PropertyType.String)
				throw new ArgumentException($"Property '{propertyId}' is not supposed to be a string, or is missing from the property type switch.");

			lock (_properties)
			{
				if (!_properties.TryGetValue(propertyId, out var property))
					_properties[propertyId] = new StringProperty(propertyId, value);
				else
					(property as StringProperty).Value = value;
			}
		}

		/// <summary>
		/// Adds the given property
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="value"></param>
		public void Add(IProperty property)
		{
			if (!Enum.IsDefined(typeof(PropertyType), property.Type))
				throw new ArgumentException($"Invalid property type '{property.Type}'.");

			lock (_properties)
				_properties[property.Id] = property;
		}

		/// <summary>
		/// Removes given property, returns false if the property didn't
		/// exist.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <returns></returns>
		public bool Remove(int propertyId)
		{
			lock (_properties)
				return _properties.Remove(propertyId);
		}

		/// <summary>
		/// Returns the given property's type.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <returns></returns>
		public static PropertyType GetPropertyType(int propertyId)
		{
			// This is a terrible way to handle this, but it's the only
			// one we got. Extend this switch case as we find new string
			// values, which IMC apparently use for anything that's not
			// fit to be a float, like coordinates or precise, large
			// numbers.

			switch (propertyId)
			{
				case PropertyId.Account.Medal_Get_Date:
				case PropertyId.Account.LimitPaymentStateBySteam:
				case PropertyId.PC.JobName:                          // Char1_1
				case PropertyId.PC.LastExp:
				case PropertyId.PC.AbilityPoint:
				case PropertyId.PCEtc.Kill_boss_Velmosquy:
				case PropertyId.PCEtc.LastUIOpenPos:                 // f_siauliai_2/219/151.86210632324/706/worldmap (this feels so wrong)
				case PropertyId.PCEtc.StartHairName:
				case PropertyId.PCEtc.RepresentationClassID:
				case PropertyId.PCEtc.SkintoneName:
				case PropertyId.Party.P_PARTY_Q_030_TicketLifeTime:
				case PropertyId.SessionObject.DROPITEM_COLLECTINGQUEST_RR:
				case PropertyId.SessionObject.LAST_EVENT_RESET_DATE:
				case PropertyId.SessionObject.QSTARTZONETYPE:
				case PropertyId.SessionObject.LastGenPosServer:      // -1246/-648
				case PropertyId.SessionObject.DROPITEM_REQUEST1_RR:
				case PropertyId.SessionObject.DROPITEM_REQUEST1_TRL:
				case PropertyId.SessionObject.CHARACTER_ATTENDANCE_CHECK:
					return PropertyType.String;
				default:
					return PropertyType.Float;
			}
		}
	}
}
