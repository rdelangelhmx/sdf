#region --- Copyright Information --- 
/*
 *******************************************************************
|                                                                   |
|           OpenNETCF Smart Device Framework 2.2                    |
|                                                                   |
|                                                                   |
|       Copyright (c) 2000-2008 OpenNETCF Consulting LLC            |
|       ALL RIGHTS RESERVED                                         |
|                                                                   |
|   The entire contents of this file is protected by U.S. and       |
|   International Copyright Laws. Unauthorized reproduction,        |
|   reverse-engineering, and distribution of all or any portion of  |
|   the code contained in this file is strictly prohibited and may  |
|   result in severe civil and criminal penalties and will be       |
|   prosecuted to the maximum extent possible under the law.        |
|                                                                   |
|   RESTRICTIONS                                                    |
|                                                                   |
|   THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES           |
|   ARE CONFIDENTIAL AND PROPRIETARY TRADE                          |
|   SECRETS OF OPENNETCF CONSULTING LLC THE REGISTERED DEVELOPER IS |
|   LICENSED TO DISTRIBUTE THE PRODUCT AND ALL ACCOMPANYING .NET    |
|   CONTROLS AS PART OF A COMPILED EXECUTABLE PROGRAM ONLY.         |
|                                                                   |
|   THE SOURCE CODE CONTAINED WITHIN THIS FILE AND ALL RELATED      |
|   FILES OR ANY PORTION OF ITS CONTENTS SHALL AT NO TIME BE        |
|   COPIED, TRANSFERRED, SOLD, DISTRIBUTED, OR OTHERWISE MADE       |
|   AVAILABLE TO OTHER INDIVIDUALS WITHOUT EXPRESS WRITTEN CONSENT  |
|   AND PERMISSION FROM OPENNETCF CONSULTING LLC                    |
|                                                                   |
|   CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON       |
|   ADDITIONAL RESTRICTIONS.                                        |
|                                                                   |
 ******************************************************************* 
*/
#endregion



using System;

namespace OpenNETCF.Net
{
	/// <summary>
	/// Different NIC adapter types
	/// </summary>
	public enum AdapterType
	{
		/// <summary>
        /// Unknown or unresolvable adapter type
        /// </summary>
        Unknown = 0,

		/// <summary>
		/// Adapter type not known at compile time
		/// </summary>
		Other = 1,

		/// <summary>
		/// Ethernet adapter.  Also includes RF Ethernet
		/// </summary>
		Ethernet = 6,

		/// <summary>
		/// Token ring adapter
		/// </summary>
		TokenRing = 9,

		/// <summary>
		/// Fiber optic adapter
		/// </summary>
		FDDI = 15,

		/// <summary>
		/// Dial-up/serial adapter using PPP protocol
		/// </summary>
		PPP = 23,

		/// <summary>
		/// Loopback adapter
		/// </summary>
		Loopback = 24,

		/// <summary>
		/// Dial-up/serial adapter using SLIP protocol
		/// </summary>
		SLIP = 28,
	}
}