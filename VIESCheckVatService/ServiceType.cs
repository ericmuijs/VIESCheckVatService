﻿// VIES VAT number validation
// Copyright (C) 2009-2014  Antonio Musarra (http://www.dontesta.it/blog)
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

/*
 * Created by SharpDevelop.
 * User: musarra
 * Date: 22/07/2014
 * Time: 17.02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VIESCheckVatService
{
	/// <summary>
	/// Description of ServiceType.
	/// </summary>
	public enum ServiceType
	{
		/// <summary>
		/// For SOAP Service Type
		/// </summary>
		SOAP,
		
		/// <summary>
		/// For REST Service Type
		/// </summary>
		REST
	}
}
